// This code was autogenerated.
// Changes to this file will be lost if the file is regenerated.
using System;
namespace PowerDoc.PowerObjects {
	public class Application : HardwiredObject {
		static Application instance;

		static Application() {
			instance = new Application();
		}

		static public void Init() {
		}

		public static Application Instance {
			get { return instance; }
		}

		protected Application() : base(PowerObject.PowerObjectParent, "Application", PowerObject.PowerObjectInstance) {
		}
	}
}