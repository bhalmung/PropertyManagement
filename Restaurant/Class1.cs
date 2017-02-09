using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using DotNetNuke.Entities.Portals;
using System.Drawing.Drawing2D;
using System.Web.UI;

namespace DnnEstateAgent.BLL.Image
{
    /// <summary>
    /// Class that handles scaling images to a smaller size
    /// </summary>
    public class ImageUtil
    {
        private string outputPath;
        int portalId;
        //string baseFolder;

        /// <summary>
        /// cstor
        /// </summary>
        /// <param name="portalId"></param>
        public ImageUtil(int portalId)
        {
            this.portalId = portalId;
            outputPath = HttpContext.Current.Server.MapPath("~/DesktopModules/DnnEstateAgent/PropertyFiles/" + portalId);
        }

        /// <summary>
        /// output path to write the images to
        /// </summary>
        /// <remarks>If not set the default location is the module folder /propertyfile folder</remarks>
        private string OutputPath
        {
            get { return outputPath; }
        }

        /// <summary>
        /// Scales an image to a new size
        /// </summary>
        /// <param name="imageFileLocation">URL filepath to the image</param>
        /// <param name="width">width for the newly created scaled image</param>
        /// <param name="overwriteExisting">if true an existing file with
        /// the same name will be over written</param>
        public void ScaleImage(string imageFileLocation, int width, bool overwriteExisting)
        {
            System.Drawing.Image image;
            string outputName = this.ScaledImageOutput(imageFileLocation, width);

            //skip doing the scaling if the file already exists
            if (File.Exists(outputName) && !overwriteExisting)
                return;


            string fileLocation = HttpContext.Current.Server.MapPath(imageFileLocation);

            if (File.Exists(fileLocation))
            {
                using (image = System.Drawing.Image.FromFile(fileLocation))
                {
                    Size thumbSize = ThumbSize(image.Width, image.Height, Convert.ToInt16(width));

                    using (Bitmap thumb = new Bitmap(thumbSize.Width, thumbSize.Height))
                    {
                        Graphics g = Graphics.FromImage(thumb);
                        g.CompositingQuality = CompositingQuality.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        g.DrawImage(image, 0, 0, thumbSize.Width, thumbSize.Height);

                        //check folder exists
                        if (!Directory.Exists(OutputPath))
                            Directory.CreateDirectory(OutputPath);

                        thumb.Save(outputName, image.RawFormat);
                    }
                }
            }

        }


        /// <summary>
        /// Determines the full filepath and filename that will be
        /// used to output the scaled image to disk
        /// </summary>
        /// <param name="imageFileLocation"></param>
        /// <returns></returns>
        private string ScaledImageOutput(string imageFileLocation, int width)
        {
            string fileLocation = HttpContext.Current.Server.MapPath(imageFileLocation);
            string filename = Path.GetFileNameWithoutExtension(fileLocation);

            return string.Format("{0}\\{4}\\{1}_{2}{3}", OutputPath,
                                                            filename,
                                                            width,
                                                            Path.GetExtension(fileLocation),
                                                            new DirectoryInfo(Path.GetDirectoryName(imageFileLocation)).Name);
        }

        /// <summary>
        /// Determines the size of the name image that we are scaling
        /// </summary>
        /// <param name="currentWidth"></param>
        /// <param name="currentHeight"></param>
        /// <param name="newWidth"></param>
        /// <returns></returns>
        private Size ThumbSize(int currentWidth, int currentHeight, int newWidth)
        {
            double iMultiplier;

            iMultiplier = Convert.ToDouble(newWidth) / currentWidth;


            return new Size(Convert.ToInt16(currentWidth * iMultiplier), Convert.ToInt16(currentHeight * iMultiplier));
        }
    }
}