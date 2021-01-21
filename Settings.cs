using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace AutoOpen
{
    public class Settings : ISettings
    {

        public Settings()
        {
            Enable = new ToggleNode(false);
            Speed = new RangeNode<int>(1, 0, 100);
            BlockInput = new ToggleNode(true);

            Doors = new ToggleNode(true);
            Switches = new ToggleNode(true);
            Chests = new ToggleNode(true);
            Shrines = new ToggleNode(true);

            DoorDistance = new RangeNode<int>(150, 0, 300);
            SwitchDistance = new RangeNode<int>(150, 0, 300);
            ChestDistance = new RangeNode<int>(150, 0, 300);
            ToggleEntityKey = new HotkeyNode(Keys.V);
            ShrineDistance = new RangeNode<int>(150, 0, 300);
        }

        [Menu("Enable")]
        public ToggleNode Enable { get; set; }

        [Menu("Blacklist|Whitelist Key")]
        public HotkeyNode ToggleEntityKey { get; set; }

        [Menu("Block User Input")]
        public ToggleNode BlockInput { get; set; }

        [Menu("Click Delay")]
        public RangeNode<int> Speed { get; set; }

        [Menu("Doors", 1000)]
        public ToggleNode Doors { get; set; }

        [Menu("Distance", 1001, 1000)]
        public RangeNode<int> DoorDistance { get; set; }

        [Menu("Switches/Levers", 2000)]
        public ToggleNode Switches { get; set; }

        [Menu("Distance", 2001, 2000)]
        public RangeNode<int> SwitchDistance { get; set; }

        [Menu("Chests", 3000)]
        public ToggleNode Chests { get; set; }

        [Menu("Distance", 3002, 3000)]
        public RangeNode<int> ChestDistance { get; set; }

        [Menu("Shrines", 4000)]
        public ToggleNode Shrines { get; set; }

        [Menu("Distance", 4001, 4000)]
        public RangeNode<int> ShrineDistance { get; set; }
    }
}