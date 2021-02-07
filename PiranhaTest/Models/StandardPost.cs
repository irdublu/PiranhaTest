using Piranha.AttributeBuilder;
using Piranha.Models;

namespace PiranhaTest.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}