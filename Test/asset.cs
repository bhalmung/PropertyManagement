using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MediaServices.Client;
using System.IO;

namespace Test
{
    class asset
    {
        public void t()
           
        {
            var context = new CloudMediaContext("medulawmedia", "H9jZUXCx7zX0Jihemd4yoSDZ6XWFKiIfpCGOQiOXzIQ=");
            // The local path to the file to upload to the new asset.
            string filePath = @"D:\DNN\Helium5\DesktopModules\MVC\purplecs\DNNGameBoard\video\17_Augmentation Mammoplasty.mp4";
            var assetName = Path.GetFileName(filePath);
            // The options for creating the new asset.
            AssetCreationOptions assetCreationOptions = AssetCreationOptions.None;

            // Create a new asset and upload a local file using a single extension method.
            IAsset asset = context.Assets.Create(assetName, assetCreationOptions);

            var assetFile = asset.AssetFiles.Create(assetName);
            assetFile.IsPrimary = true;

            var storeage = asset.StorageAccountName;
            var policy = context.AccessPolicies.Create(
                           assetName,
                           TimeSpan.FromDays(30000),
                           AccessPermissions.List | AccessPermissions.Read);

            var locator = context.Locators.CreateLocator(LocatorType.Sas, asset, policy);
            var rul = asset.Uri;
            assetFile.Upload(filePath);
            Console.WriteLine("Done uploading {0}", assetFile.Name);
            var url = locator.BaseUri + assetName + locator.ContentAccessComponent;
            locator.Delete();
            policy.Delete();
        }
    }
}
