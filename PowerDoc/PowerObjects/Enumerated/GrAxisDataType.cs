// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class GrAxisDataType : HardwiredObject {
		static GrAxisDataType instance;

		static GrAxisDataType() {
			instance = new GrAxisDataType();
		}

		static public void Init() {
		}

		public static GrAxisDataType Instance {
			get { return instance; }
		}

		protected GrAxisDataType() : base(PowerObject.PowerObjectParent, "GrAxisDataType", EnumeratedType.Instance) {
		}
	}
}