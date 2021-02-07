using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using PiranhaTest.Models.Regions;

namespace PiranhaTest.Models
{
   [PageType(Title = "Simple2")]
   [PageTypeRoute(Title = "Simple2", Route = "/simple2")]
   public class Simple2 : Page<Simple2>
   {
      /// <summary>
      /// Gets/sets the page header.
      /// </summary>
      [Region]
      public Regions.Hero Hero { get; set; }

      [Region]
      public MyRegion MyRegion { get; set; }
   }
}
