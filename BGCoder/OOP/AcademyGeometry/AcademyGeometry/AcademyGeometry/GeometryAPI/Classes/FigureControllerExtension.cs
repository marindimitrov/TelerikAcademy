using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryAPI;

namespace GeometryAPI
{
    public class FigureControllerExtension : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D circleCenter = Vector3D.Parse(splitFigString[1]);
                        double circleRadius = double.Parse(splitFigString[2]);
                        currentFigure = new Circle(circleCenter, circleRadius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D cylinderBottomCircleCenter = Vector3D.Parse(splitFigString[1]);
                        Vector3D cylinderTopCircleCenter = Vector3D.Parse(splitFigString[2]);
                        double cylinderRadius = double.Parse(splitFigString[3]);
                        currentFigure = new Cylinder(cylinderBottomCircleCenter, cylinderTopCircleCenter, cylinderRadius);
                        break;
                    }
            }

            base.ExecuteFigureCreationCommand(splitFigString);
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        IAreaMeasurable myTest = currentFigure as IAreaMeasurable;
                        if (myTest != null)
                        {
                            Console.WriteLine("{0:0.00}", myTest.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        IVolumeMeasurable myTest = currentFigure as IVolumeMeasurable;
                        if (myTest != null)
                        {
                            Console.WriteLine("{0:0.00}", myTest.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        IFlat myTest = currentFigure as IFlat;
                        if (myTest != null)
                        {
                            Console.WriteLine(myTest.GetNormal().ToString());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }
            base.ExecuteFigureInstanceCommand(splitCommand);
        }
    }
}