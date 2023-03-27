using Microsoft.AspNet.Identity;
using phamtiendung_2011062063bai3.DTOs;
using phamtiendung_2011062063bai3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace phamtiendung_2011062063bai3.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");

            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };

            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();

            return Ok();
        }

    }
}