using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ver1.IDevice;

namespace ver1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; private set; } = 0;
        public int ScanCounter { get; private set; } = 0;

        
        public void Print(in IDocument document)
        {
			if (GetState() == IDevice.State.on)
			{
				DateTime printTime = DateTime.Now;
				Console.WriteLine($"{printTime} Print: {document.GetFileName()}");
				PrintCounter++;
			}
			else
			{
				Console.WriteLine("Cannot print, device is off");
			}
		}

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.JPG)
        {
            throw new NotImplementedException();
        }

        public void ScanAndPrint()
        {
            throw new NotImplementedException();
        }



    }
}
