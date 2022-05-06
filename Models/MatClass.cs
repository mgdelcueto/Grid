namespace  DevExtremeAsp.Models{
    public class MatClass {
        public string Code { get; set; }
        public string Name { get; set; }

        public MatClass(string code, string name) {
            this.Code = code;
            this.Name = name;

        }
    }
}