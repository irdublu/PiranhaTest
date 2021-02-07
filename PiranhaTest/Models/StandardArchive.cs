using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PiranhaTest.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}