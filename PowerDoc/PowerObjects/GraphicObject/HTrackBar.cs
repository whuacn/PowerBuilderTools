// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class HTrackBar : HardwiredObject {
		static HTrackBar instance;

		static HTrackBar() {
			instance = new HTrackBar();
		}

		static public void Init() {
		}

		public static HTrackBar Instance {
			get { return instance; }
		}

		protected HTrackBar() : base(PowerObject.PowerObjectParent, "HTrackBar", DragObject.Instance) {
		}
	}
}
