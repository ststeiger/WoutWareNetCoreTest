
namespace WoutWareNetCoreTest
{
    
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            WW.WWLicense.SetLicense("AQAAAG8k3LVHqvLi1bJYXpQFgmtG/MRWYZcdrTG2MlOUb1E3Pe/4mkhuVSyJ6eXKeGH5jY9kSEBa94uYpww4TBqiLMFVTgOI9z5+ZRTZJ5szezpYXlMvpVuAmXb2EWGMUYcdWKYP0WMTGDTStjaKqQZGA4f0rpKYak0D1/n/6GWpPYEp");

            string filename = @"/root/github/WoutWareNetCoreTest/WoutWareNetCoreTest/Zimmertyp_1_.dwg";
            filename = @"/root/github/WoutWareNetCoreTest/WoutWareNetCoreTest/Zimmertyp_2_.dwg";
            
            
            // apt-file search Arimo-Regular.ttf
            //     ==> fonts-croscore
            // apt-get install fonts-croscore
            // updatedb, locate Arimo-Regular.ttf
            // ==> /usr/share/fonts/truetype/croscore/Arimo-Regular.ttf
            // http://ubuntuhandbook.org/index.php/2016/05/manually-install-fonts-ubuntu-16-04/
            // fc-cache -fv
            
            WW.Cad.Model.DxfModel model;
            string extension = System.IO.Path.GetExtension(filename);
            if (string.Compare(extension, ".dwg", true) == 0)
            {
                model = WW.Cad.IO.DwgReader.Read(filename);
                /*
                System.Exception: Could not find font Arimo-Regular.ttf or any of the fallback fonts Arimo-Regular.ttf, Arimo-Regular.ttf.
  at at .(String , Boolean , Boolean , FontFamily& , FontStyle& )
  at at .(String , Boolean , Boolean , FontFamily& , FontStyle& )
  at at ...ctor(String , Boolean , Boolean )
  at at .(String , Boolean , Boolean )
  at at ..ctor( , Boolean )
  at at .get_()
  at at .get_()
  at at ..ctor( )
  at at .(String , Double , Double , AttachmentPoint , Double , LineSpacingStyle , DxfTextStyle , Double , Color , DrawingDirection , String& )
  at at .(String , Double , Double , AttachmentPoint , Double , LineSpacingStyle , DxfTextStyle , Double , Color , DrawingDirection )
  at at .(String , Double , Double , AttachmentPoint , Double , LineSpacingStyle , DxfTextStyle , Double , Color , DrawingDirection , Int16 , Matrix4D ,  ,  )
  at at .(DxfModel , DxfMText , Color , Int16 , Matrix4D , Bounds2D )
  at at WW.Cad.Model.Entities.DxfMText.(DrawContext , IPathDrawer )
  at at WW.Cad.Model.Entities.DxfMText.DrawInternal(Wireframe context, IWireframeGraphicsFactory graphicsFactory)
  at at WW.Cad.Model.Entities.DxfEntity.Draw(Wireframe context, IWireframeGraphicsFactory graphicsFactory)
  at at WW.Cad.Model.Entities.DxfInsert..(DxfEntity )
  at at WW.Cad.Model.Tables.DxfBlock.( , Boolean )
  at at WW.Cad.Model.Entities.DxfInsert..(DxfBlock , Boolean )
  at at WW.Cad.Model.Entities.DxfInsert.( , Boolean )
  at at WW.Cad.Model.Entities.DxfInsert.DrawInternal(Wireframe context, IWireframeGraphicsFactory graphicsFactory)
  at at WW.Cad.Model.Entities.DxfEntity.Draw(Wireframe context, IWireframeGraphicsFactory graphicsFactory)
  at at WW.Cad.Drawing.BoundsCalculator.GetBounds(DxfModel model, Matrix4D modelTransform)
  at at WW.Cad.Drawing.BoundsCalculator.GetBounds(DxfModel model)
  at at WW.Cad.Model.DxfModel.(Boolean )
  at at WW.Cad.IO.DwgReader.Read()
  at at WW.Cad.IO.DwgReader.Read(String filename, ProgressEventHandler progressEventHandler)
  at at WW.Cad.IO.DwgReader.Read(String filename)
  at WoutWareNetCoreTest.Program.Main(String[] args) in /root/github/WoutWareNetCoreTest/WoutWareNetCoreTest/Program.cs:30
                 */
            }
            else
            {
                model = WW.Cad.IO.DxfReader.Read(filename);
            }
            
            DwgToSvgConverter.Export.ExportToSvg(model, "foobar.svg");
            
            // uname -a
            // Linux asshat 4.4.0-128-generic #154-Ubuntu SMP Fri May 25 14:15:18 UTC 2018 x86_64 x86_64 x86_64 GNU/Linux
            // lsb_release -a
            // Distributor ID:	Ubuntu
            // Description:	Ubuntu 16.04.4 LTS
            // Release:	16.04
            // Codename:	xenial
            
            System.Console.WriteLine(System.Environment.NewLine);
            System.Console.WriteLine(" --- Press any key to continue --- ");
            System.Console.ReadKey();
        }
        
        
    }
    
    
}
