using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyYoutubeService : IYouTubeService
    {
        private YouTubeService _youtubeService;
        private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();
        public ProxyYoutubeService(YouTubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }
        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Proxy youtube service getting {videoId}");
            byte[] _cachedVideo;

            if (_cache.TryGetValue(videoId, out _cachedVideo))
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return _cachedVideo;
            }

            Console.WriteLine($"Getting from youtube {videoId}");
            var video = _youtubeService.GetVideo(videoId);
            _cache.Add(videoId, video);
            return video;
        }
    }
}
