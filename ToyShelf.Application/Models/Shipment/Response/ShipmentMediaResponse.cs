using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyShelf.Domain.Entities;

namespace ToyShelf.Application.Models.Shipment.Response
{
	public class ShipmentMediaResponse
	{
		public Guid Id { get; set; }
		public string MediaUrl { get; set; } = null!;
		public ShipmentMediaType MediaType { get; set; }
		public ShipmentMediaPurpose Purpose { get; set; }
		public DateTime CreatedAt { get; set; }
		public Guid UploadedByUserId { get; set; }
		public string UploadedByName { get; set; } = null!;
	}
}
