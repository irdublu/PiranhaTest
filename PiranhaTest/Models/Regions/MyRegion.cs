using Piranha.Extend;
using Piranha.Extend.Fields;

namespace PiranhaTest.Models.Regions
{
   public class MyRegion
   {
      [Field(Title = "The Title")]
      public StringField MyTitle { get; set; }

      [Field]
      public TextField MyBody { get; set; }

      [Field(Placeholder = "Please enter your full name")]
      public StringField MyName { get; set; }

      [Field(Placeholder = "Check me out!")]
      public CheckBoxField MyBoolValue { get; set; }

      [Field]
      public HtmlField MyHtmlValue { get; set; }
   }
}
