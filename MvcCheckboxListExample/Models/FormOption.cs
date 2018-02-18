namespace MvcCheckboxListExample.Models {
    public class FormOption {
        /// <summary>
        /// An identifier used on controller-side to identify which checkbox this is (also applied as Id on rendered <div>, for style or script use)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The boolean for the checkbox that gets rendered
        /// </summary>
        public bool Checked { get; set; }

        /// <summary>
        /// The text for the label that gets rendered
        /// </summary>
        public string Label { get; set; }
    }
}