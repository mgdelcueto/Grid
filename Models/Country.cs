namespace  DevExtremeAsp.Models {
    public class Country {
        public string Code { get; set; }
        public string Name { get; set; }

        public Country(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}