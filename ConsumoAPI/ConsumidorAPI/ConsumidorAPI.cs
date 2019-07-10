using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using ConsumoAPI.Models;
using Newtonsoft.Json;

namespace ConsumoAPI.ConsumidorAPI
{
    /// <summary>
    /// Se define el metodo para cada servicio a consumir y 
    /// </summary>
    public class ConsumidorApi
    {
        public async Task<Comment> GetCommentAsync(int Id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/comments/"+ Id.ToString());
            Comment comment = JsonConvert.DeserializeObject<Comment>(json);
            return comment; 
        }

        public async Task<Post> GetPostAsync(int Id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts/"+ Id.ToString());
            Post post = JsonConvert.DeserializeObject<Post>(json);
            return post;
        }

        public async Task<Album> GetAlbumAsync(int Id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/albums/"+ Id.ToString());
            Album album = JsonConvert.DeserializeObject<Album>(json);
            return album;
        }

        public async Task<Photo> GetPhotoAsync(int Id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/photos/"+ Id.ToString());
            Photo photo = JsonConvert.DeserializeObject<Photo>(json);
            return photo;
        }
    }
}