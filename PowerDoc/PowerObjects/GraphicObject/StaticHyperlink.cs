// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class StaticHyperlink : HardwiredObject {
		static StaticHyperlink instance;

		static StaticHyperlink() {
			instance = new StaticHyperlink();
		}

		static public void Init() {
		}

		public static StaticHyperlink Instance {
			get { return instance; }
		}

		protected StaticHyperlink() : base(PowerObject.PowerObjectParent, "StaticHyperlink", DragObject.Instance) {
		}
	}
}