namespace  DevExtremeAsp.Models {
    public class MeasureU {
        public string Code { get; set; }
        public string Name { get; set; }

        public MeasureU(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}