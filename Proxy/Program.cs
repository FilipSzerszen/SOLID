using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeService youTubeService = new YouTubeService();
            youTubeService.GetVideo(10);
            youTubeService.GetVideo(10);

            ProxyYoutubeService proxyYoutube = new ProxyYoutubeService(youTubeService);
            proxyYoutube.GetVideo(10);
            proxyYoutube.GetVideo(10);

        }
    }
}
