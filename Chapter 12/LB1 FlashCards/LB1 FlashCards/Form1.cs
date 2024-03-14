namespace LB1_FlashCards
{
    public partial class Flash_Cards : Form
    {
        private TermManager termManager;
        public Flash_Cards()
        {
            InitializeComponent();
            termManager = new TermManager();
        }

        public class TermManager
        {
            private Dictionary<string, string> terms;

            public TermManager()
            {
                terms = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                    { "OOP", "Object-Oriented Programming: a programming paradigm based on the concept of objects." },
                    { "Encapsulation", "The bundling of data, along with the methods that operate on these data." },
                    { "Polymorphism", "The provision of a single interface to entities of different types." },
                    { "Inheritance", "The mechanism of basing an object or class upon another object or class." },
                    { "Abstraction", "Process of hiding the internal data and implementation from the outer world." }
                };
            }

            public string GetDefinition(string term)
            {
                if (terms.TryGetValue(term, out string definition))
                {
                    return definition;
                }
                return null;
            }

            public void AddTerm(string term, string definition)
            {
                if (!terms.ContainsKey(term))
                {
                    terms[term] = definition;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            var term = txtSearch.Text.Trim();
            var definition = termManager.GetDefinition(term);

            if (definition != null)
            {
                lblDefinition.Text = definition;
                txtAdd.Visible = false;
                btnAdd.Visible = false;
            }
            else
            {
                lblDefinition.Text = "I don't know that term yet. What does it mean?";
                txtAdd.Visible = true;
                btnAdd.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var term = txtSearch.Text.Trim();
            var definition = txtAdd.Text.Trim();

            if (!string.IsNullOrWhiteSpace(definition))
            {
                termManager.AddTerm(term, definition);
                lblDefinition.Text = $"Definition added: {definition}";
                txtSearch.Clear();
                txtAdd.Clear();
                txtAdd.Visible = false;
                btnAdd.Visible = false;
            }
            else
            {
                lblDefinition.Text = "Please enter a definition.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtAdd.Clear();
            lblDefinition.Text = string.Empty;
            txtAdd.Visible = false;
            btnAdd.Visible = false;
        }
    }
}
