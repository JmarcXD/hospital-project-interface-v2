namespace hospital_project_interface_v2
{
    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }
    }
}
