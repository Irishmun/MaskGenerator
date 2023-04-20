using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MaskGenerator
{

    public partial class Form1 : Form
    {
        private Size _smallestSize;
        private Bitmap[] _setImages = new Bitmap[5];
        private ImageEdit _edit = new ImageEdit();
        public Form1()
        {
            InitializeComponent();
            PB_RedChannel.AllowDrop = true;
            PB_GreenChannel.AllowDrop = true;
            PB_BlueChannel.AllowDrop = true;
            PB_Mask.AllowDrop = true;
            PB_AlphaChannel.AllowDrop = true;
            _smallestSize = new Size(int.MaxValue, int.MaxValue);
            TSSL_OutputSize.Text = "Drag an image to set size";
        }

        #region Form Events
        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb == null)
            { return; }
            if (GetFilename(out string filename, e))
            {
                Debug.WriteLine(filename);
                Bitmap newImg = new Bitmap(filename);
                if (newImg != null)
                {
                    SetImagesAndSmallest(pb, newImg);
                }
            }
        }
        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void BT_ToMask_Click(object sender, EventArgs e)
        {
            if (_smallestSize.Width == int.MaxValue)
            { return; }

            int index = GetFirstNonEmpty(_setImages);
            //TODO: fix issue regarding indexed format images
            /*
             *https://stackoverflow.com/a/32002319
             *it occured because some types of PixelFormat causes ArgumentException when passed to new Bitmap(). Here is list of these types:
             *Gdi
             *Alpha
             *PAlpha
             *Extended
             *Canonical
             *Undefined
             *DontCare
             */
            //PixelFormat format;
            //if (index < 0)
            //{ format = PixelFormat.Format32bppArgb; }
            //else
            //{ format = _setImages[index].PixelFormat; }

            Bitmap maskImage = new Bitmap(_smallestSize.Width, _smallestSize.Height, PixelFormat.Format32bppArgb);
            Bitmap RedMap = _edit.ScaledImage(PB_RedChannel.Image, _smallestSize);
            Bitmap GreenMap = _edit.ScaledImage(PB_GreenChannel.Image, _smallestSize);
            Bitmap BlueMap = _edit.ScaledImage(PB_BlueChannel.Image, _smallestSize);
            Bitmap AlphaMap = _edit.ScaledImage(PB_AlphaChannel.Image, _smallestSize);

            for (int x = 0; x < maskImage.Width; x++)
            {
                for (int y = 0; y < maskImage.Height; y++)
                {
                    Color curPixel = maskImage.GetPixel(x, y);
                    byte r = _edit.FloatToByte(_edit.GetVibrancy(RedMap, x, y));
                    byte g = _edit.FloatToByte(_edit.GetVibrancy(GreenMap, x, y));
                    byte b = _edit.FloatToByte(_edit.GetVibrancy(BlueMap, x, y));
                    byte a = CB_AlphaOne.Checked == true ? byte.MaxValue : _edit.FloatToByte(_edit.GetVibrancy(AlphaMap, x, y));
                    Color col = _edit.SetChannels(curPixel, r, g, b, a);
                    //maskImage.SetPixel(x, y, _edit.SetChannels(curPixel, r, g, b, a));
                    maskImage.SetPixel(x, y, col);
                }
            }
            Debug.WriteLine("done");
            PB_Mask.Image = maskImage;
        }

        private void BT_ToChannels_Click(object sender, EventArgs e)
        {
            if (PB_Mask.Image == null)
            { return; }
            Bitmap MaskBmp = new Bitmap(PB_Mask.Image);
            Bitmap Rbmp = new Bitmap(MaskBmp.Width, MaskBmp.Height);
            Bitmap Gbmp = new Bitmap(MaskBmp.Width, MaskBmp.Height);
            Bitmap Bbmp = new Bitmap(MaskBmp.Width, MaskBmp.Height);
            Bitmap Abmp = new Bitmap(MaskBmp.Width, MaskBmp.Height);
            for (int x = 0; x < MaskBmp.Width; x++)
            {
                for (int y = 0; y < MaskBmp.Height; y++)
                {
                    Color col = MaskBmp.GetPixel(x, y);
                    Rbmp.SetPixel(x, y, Color.FromArgb(255, col.R, col.R, col.R));
                    Gbmp.SetPixel(x, y, Color.FromArgb(255, col.G, col.G, col.G));
                    Bbmp.SetPixel(x, y, Color.FromArgb(255, col.B, col.B, col.B));
                    Abmp.SetPixel(x, y, Color.FromArgb(255, col.A, col.A, col.A));
                }
            }
            SetImagesAndSmallest(PB_RedChannel, Rbmp);
            SetImagesAndSmallest(PB_BlueChannel, Gbmp);
            SetImagesAndSmallest(PB_GreenChannel, Bbmp);
            SetImagesAndSmallest(PB_AlphaChannel, Abmp);
        }
        private void BT_SaveMask_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //(ext == ".jpg") || (ext == ".png") || (ext == ".bmp") || (ext == ".tga") || (ext == ".tiff") || (ext == ".jpeg")
            saveFileDialog1.Filter = "png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Tiff Image|*.tiff";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.PB_Mask.Image.Save(fs, ImageFormat.Png);
                        break;

                    case 2:
                        this.PB_Mask.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 3:
                        this.PB_Mask.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 4:
                        this.PB_Mask.Image.Save(fs, ImageFormat.Tiff);
                        break;
                }

                fs.Close();
            }
        }

        private void BT_ClearImage_Click(object sender, EventArgs e)
        {
            PictureBox pb = TryGetPictureBox((sender as Control).Tag.ToString());
            if (pb == null)
            { return; }
            if (pb.Image == null)
            { return; }
            int index = Array.IndexOf(_setImages, pb.Image);
            if (index < 0)
            { return; }
            _setImages[index] = null;
            pb.Image = null;
        }

        private void BT_CopyChannel_Click(object sender, EventArgs e)
        {
            PictureBox pb = TryGetPictureBox((sender as Control).Tag.ToString());
            if (pb == null)
            { return; }
            if (pb.Image == null)
            { return; }
            Clipboard.SetImage(pb.Image);
            TSSL_OutputSize.Text = "Copied.";
        }
        #endregion

        #region methods

        private PictureBox TryGetPictureBox(string name)
        {
            Control[] controls = this.Controls.Find(name, true);
            PictureBox pb = null;
            if (controls.Length > 0)
            {
                pb = controls[0] as PictureBox;
                if (pb != null)
                {
                    return pb;
                }
            }
            else
            {
                Debug.WriteLine("No Control found by name: " + name);
            }
            return null;
        }

        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is string))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp") || (ext == ".tga") || (ext == ".tiff") || (ext == ".jpeg"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }

        private void SetImagesAndSmallest(PictureBox pb, Bitmap image)
        {
            int index = Array.IndexOf(_setImages, pb.Image);
            if (index >= 0)
            {
                _setImages[index] = image;
            }
            else
            {
                _setImages[GetFirstEmpty(_setImages)] = image;
            }
            pb.Image = image;

            SetSmallest(image);
        }

        private void SetSmallest(Bitmap image)
        {
            bool newSmallest = true;//new smallest value (greater than previous smallest)
            for (int i = 0; i < _setImages.Length; i++)
            {
                if (_setImages[i] == null)
                { continue; }
                if (_setImages[i].Width <= _smallestSize.Width && _setImages[i].Height <= _smallestSize.Height)
                {
                    //there still is an image that is smaller than the last smallest
                    newSmallest = false;
                    break;
                }
            }
            if (newSmallest == false)
            {
                if (image.Width < _smallestSize.Width && image.Height < _smallestSize.Height)
                {
                    _smallestSize = new Size(image.Width, image.Height);
                }
            }
            else
            {//set new smallest size
                Point currentSmallest = new Point(int.MaxValue, int.MaxValue);
                for (int i = 0; i < _setImages.Length; i++)
                {
                    if (_setImages[i] == null)
                    { continue; }
                    if (_setImages[i].Width <= currentSmallest.X && _setImages[i].Height <= currentSmallest.Y)
                    {
                        //there still is an image that is smaller than the last smallest
                        _smallestSize = new Size(image.Width, image.Height);
                    }
                }
            }
            TSSL_OutputSize.Text = $"Output size: {_smallestSize.Width}x{_smallestSize.Height}";
        }
        private int GetFirstEmpty<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {//put new image in first empty slot
                if (array[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        private int GetFirstNonEmpty<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {//put new image in first empty slot
                if (array[i] != null)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

    }
}
