using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExpressionTreePresentation.Business.Objects;

namespace ExpressionTreePresentation.Business.Services
{
    /// <summary>
    /// Video Service
    /// </summary>
    public class VideoServices
    {
        ///// <summary>
        /////     Initializes a new instance of the <see cref="ServicesBase" /> service.
        ///// </summary>
        ///// <param name="servicesContext">The service context.</param>
        ///// <exception cref="ArgumentNullException">servicesContext is null</exception>
        ///// <exception cref="ArgumentException">servicesContext.AsicAuditContext is null</exception>
        ///// <exception cref="ArgumentException">servicesContext.Mapper is null</exception>
        //protected ServicesBase(IServicesContext servicesContext)
        //{
        //    ServicesContext = servicesContext ?? throw new ArgumentNullException(nameof(servicesContext));

        //    if (servicesContext.AsicAuditContext == null)
        //    {
        //        throw new ArgumentException("VisitorPassContext can not be null", nameof(servicesContext));
        //    }

        //    if (servicesContext.Mapper == null)
        //    {
        //        throw new ArgumentException("Mapper can not be null", nameof(servicesContext));
        //    }
        //}

        ///// <summary>
        /////     Gets the <seealso cref="IMapper" /> for the current service context.
        ///// </summary>
        //public IMapper Mapper => ServicesContext.Mapper;


        ///// <summary>
        /////     Gets the <seealso cref="AsicAuditContext" /> for the current service context.
        ///// </summary>
        //public AsicAuditProdContext AsicAuditContext => ServicesContext.AsicAuditContext;

        public Task<List<Video>> GetAll()
        {
            return Task.FromResult(new List<Video>
            {
                new Video
                {
                    ChannelName = "Adrian", Dislikes = 1, Id = 1, Likes = 100, PublishedAt = DateTimeOffset.Now,
                    Title = "Test", Views = 123
                }
            });
        }
    }
}
