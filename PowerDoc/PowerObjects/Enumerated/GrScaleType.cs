// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GrScaleType : HardwiredObject {
		static GrScaleType instance;

		static GrScaleType() {
			instance = new GrScaleType();
		}

		static public void Init() {
		}

		public static GrScaleType Instance {
			get { return instance; }
		}

		protected GrScaleType() : base(PowerObject.PowerObjectParent, "GrScaleType", EnumeratedType.Instance) {
		}
	}
}