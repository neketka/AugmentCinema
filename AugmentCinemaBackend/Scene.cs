using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;

namespace AugmentCinemaBackend
{
    public class Scene
    {
        private Mat bgImage = null;
        private Mat curFrame = null;
        private Mat corners = null;
        public Scene()
        {
        }

        public void CaptureBackground()
        {
            bgImage = new Mat();
            CaptureFrame();
            curFrame = bgImage;
            
        }

        public void CaptureFrame()
        {
            curFrame = new Mat();
            VideoCapture cap = new VideoCapture();
            cap.Read(curFrame);
            Mat exp = new Mat();
            CvInvoke.CvtColor(curFrame, exp, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            curFrame = exp;
        }

        public Mat GetTransform()
        {
            Mat status = new Mat();
            Mat err = new Mat();
            Mat outs = new Mat();
            CvInvoke.CalcOpticalFlowPyrLK(bgImage, curFrame, corners, outs, status, err, new Size(15, 15), 2,
                new Emgu.CV.Structure.MCvTermCriteria());
            return CvInvoke.GetPerspectiveTransform(corners, outs);
        }
    }
}
