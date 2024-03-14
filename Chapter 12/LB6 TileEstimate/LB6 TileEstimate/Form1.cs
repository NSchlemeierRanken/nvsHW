namespace LB6_TileEstimate
{
    public partial class Tiling_Estimator : Form
    {
        private List<Room> rooms = new List<Room>();
        private int totalBoxesNeeded = 0;
        public Tiling_Estimator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rooms.Count >= 20)
            {
                MessageBox.Show("Maximum of 20 rooms have been added.");
                return;
            }

            string name = txtName.Text;
            if (!int.TryParse(txtWidth.Text, out int width) || !int.TryParse(txtLength.Text, out int length))
            {
                MessageBox.Show("Please enter valid numbers for width and length.");
                return;
            }

            Room room = new Room(name, width, length);
            rooms.Add(room);
            totalBoxesNeeded += room.Boxes;

            UpdateRoomDetails();
            lblRoom.Text = $"Room: {rooms.Count}/20";
            lblBoxes.Text = $"Total Boxes Needed: {totalBoxesNeeded}";
            txtName.Clear();
            txtLength.Clear();
            txtWidth.Clear();
            txtName.Focus();
        }

        private void UpdateRoomDetails()
        {
            lblResults.Text = "";
            foreach (var room in rooms)
            {
                lblResults.Text += room.Display() + Environment.NewLine;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rooms.Clear();
            totalBoxesNeeded = 0;

            lblRoom.Text = "Room: 0/20";
            lblBoxes.Text = "Total Boxes Needed: 0";
            lblResults.Text = "";
            txtName.Clear();
            txtLength.Clear();
            txtWidth.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Room
    {
        private readonly string _name;
        private readonly int _width;
        private readonly int _length;
        private readonly int _area;
        private readonly int _boxes;

        public Room(string name, int width, int length)
        {
            _name = name;
            _width = width;
            _length = length;
            _area = width * length;
            _boxes = (_area / 12) + ((_area % 12) > 0 ? 1 : 0) + 1;
        }

        public string Display() => $"{_name} ({_width}x{_length}) needs {_boxes} boxes";

        public string Name => _name;
        public int Width => _width;
        public int Length => _length;
        public int Area => _area;
        public int Boxes => _boxes;
    }
}
