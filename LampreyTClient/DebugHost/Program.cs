using System.IO;
using torrent = System.Net.Torrent;

namespace DebugHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var filepath = @"..\..\..\temp\2f6e6e7fe082c73e307eed8366bf46b9bfa9c4c7.torrent";
            var torrent_metadata = torrent.Metadata.FromFile(filepath);

            var link = "magnet:?xt=urn:btih:b2632996cb10c1366160d88f199e9ade7dad3887&dn=Out%20of%20the%20Wreckage%3A%20A%20New%20Politics%20for%20an%20Age%20of%20Crisis%20-%20George%20Monbiot&tr=udp%3A%2F%2Ftracker.coppersurfer.tk%3A6969&tr=udp%3A%2F%2Ftracker.leechers-paradise.org%3A6969&tr=udp%3A%2F%2Fexplodie.org%3A6969%2Fannounce&tr=udp%3A%2F%2Ftracker.desu.sh%3A6969&tr=udp%3A%2F%2Ftracker.opentrackr.org%3A69691337%2Fannounce&tr=udp%3A%2F%2Ftracker.vanitycore.co%3A6969%2Fannounce&tr=http%3A%2F%2Ftracker.baravik.org%3A6970%2Fannounce&tr=http%3A%2F%2Ftracker2.wasabii.com.tw%3A6969%2Fannounce";
            var magnetlink = torrent.MagnetLink.Resolve(link);
            var magnetlink_metadata = new torrent.Metadata(magnetlink);
        }
    }
}
