using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Tests.Controllers.Feeds
{
    public class TestFeedEmpty: TestFeed
    {
        private string _URL = "";//"http://portals.baysoft-net.co.uk/XML_FEED/?b=4yHRIAqJ9628J1TeGdVGq4I40E25t8aj03YE5BNxmckCwkH5PfkV0kTBUYj353wO573EOJUQ5HW83buzU54VbbNAh8uvcO25HhL2K9X2KfQGX7q2d7Z1mh5ruo4m01a6nc9Aj5BUHrIw40T484544L8y21ceTmZS22V7x6BWWU56PcFtk50zDsX0ng21fSujeVP0Ht1j";
        public override string URL
        {
            get
            {
                return _URL;
            }

        }
    }
}
