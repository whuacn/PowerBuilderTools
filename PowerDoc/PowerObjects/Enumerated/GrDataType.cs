// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GrDataType : HardwiredObject {
		static GrDataType instance;

		static GrDataType() {
			instance = new GrDataType();
		}

		static public void Init() {
		}

		public static GrDataType Instance {
			get { return instance; }
		}

		protected GrDataType() : base(PowerObject.PowerObjectParent, "GrDataType", EnumeratedType.Instance) {
		}
	}
}
