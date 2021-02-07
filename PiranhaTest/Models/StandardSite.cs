using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaTest.Models
{
   [SiteType(Title = "Standard Site")]
   public class StandardSite : SiteContent<StandardSite>
   {
      [Region]
      public ImageField Logo { get; set; }

      [Region]
      public HtmlField Footer { get; set; }
   }
}
