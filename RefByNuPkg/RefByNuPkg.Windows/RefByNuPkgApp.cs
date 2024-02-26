using Stride.Engine;

namespace RefByNuPkg
{
    class RefByNuPkgApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
