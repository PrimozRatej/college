using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace AHP
{
    [Serializable]
    public class Vozlisce : TreeNode {
        public Vozlisce()
        {
        }

        public Vozlisce(string text) : base(text)
        {
        }

        public Vozlisce(string text, TreeNode[] children) : base(text, children)
        {
        }

        public Vozlisce(string text, int imageIndex, int selectedImageIndex) : base(text, imageIndex, selectedImageIndex)
        {
        }

        public Vozlisce(string text, int imageIndex, int selectedImageIndex, TreeNode[] children) : base(text, imageIndex, selectedImageIndex, children)
        {
        }

        protected Vozlisce(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
        {
        }

        public bool ImaOtroke { get; set; }
        public int IndeksOtroka { get; set; }
        public List<double> Koristnosti { get; set; }
        public List<double> Uteži { get; set; }
        public List<double> Ocene { get; set; }
    }
}
