namespace DataGrid.Configuration
{
    public class ConfigurationDG
    {
        public ConfigurationDG()
        {
            this.DataType = DataType.NotSet;
            this.Alignment = Alignment.NotSet;
            this.SortDirection = SortDirection.NotSet;
        }


        public string DataField { get; set; }
        public string Caption { get; set; }
        public string Format { get; set; }
        public DataType DataType { get; set; }
        public Alignment Alignment { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}
