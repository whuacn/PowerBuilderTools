// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class InkPicture : HardwiredObject {
		static InkPicture instance;

		static InkPicture() {
			instance = new InkPicture();
		}

		static public void Init() {
		}

		public static InkPicture Instance {
			get { return instance; }
		}

		protected InkPicture() : base(PowerObject.PowerObjectParent, "InkPicture", DragObject.Instance) {
		}
	}
}
