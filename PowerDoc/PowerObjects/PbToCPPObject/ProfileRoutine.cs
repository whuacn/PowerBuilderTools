// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class ProfileRoutine : HardwiredObject {
		static ProfileRoutine instance;

		static ProfileRoutine() {
			instance = new ProfileRoutine();
		}

		static public void Init() {
		}

		public static ProfileRoutine Instance {
			get { return instance; }
		}

		protected ProfileRoutine() : base(PowerObject.PowerObjectParent, "ProfileRoutine", PbToCPPObject.Instance) {
		}
	}
}