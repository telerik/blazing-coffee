using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazingCoffee.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GravatarController : ControllerBase
    {
        // GET api/<GravatarController>/5
        [HttpGet("{email}")]
        public string Get(string email)
        {
            return HashEmailForGravatar(email);
        }

        /// Hashes an email with MD5.  Suitable for use with Gravatar profile
        /// image urls

        string HashEmailForGravatar(string email)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(email));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();  // Return the hexadecimal string.
        }

    }
}
