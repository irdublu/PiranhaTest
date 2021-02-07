using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using PiranhaTest.Models.Regions;

namespace PiranhaTest.Models
{
   [PageType(Title = "My Simple Page")]
   [PageTypeRoute(Title = "My Simple Page", Route = "/mysimplepage")]
   public class MySimplePage : Page<MySimplePage>
   {
      /// <summary>
      /// Gets/sets the page header.
      /// </summary>
      //[Region]
      //public Hero Hero { get; set; }

      [Region]
      public MyRegion MyRegion { get; set; }
   }
}
