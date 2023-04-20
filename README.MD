# Mask Generator

This winforms tool allow you to combine images to a single mask image

# Usage

to use it, drag the image(s) to the desired channel slot OR to the mask slot.

- The `To Channels` Button will take each channel of the mask image and put them in their respective color channel as greyscale
- The `To Mask` Button will take all the images in the channels slots and combine them as a single mask image
- The `Alpha One` checkbox will replace whatever is in the alpha channel to be full values when converting to mask
- The `Clear` button will clear that respective channel or the mask image
- The `Copy` button will copy the respective image to your clipboard (no transparency)
- The `Save` button will open a prompt for you to save the mask image

# Future features

The following features are desired to add at some point in the future:

- [ ] Invert Y axis for normal maps
- [ ] Browsing for images on both the mask and channels
- [ ] Progress bar to indicate functionality when converting to or from mask