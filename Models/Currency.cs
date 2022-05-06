namespace  DevExtremeAsp.Models {
    public class Currency {
        public string Code { get; set; }
        public string Name { get; set; }

        public Currency(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}