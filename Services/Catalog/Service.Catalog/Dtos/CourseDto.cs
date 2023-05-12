using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Service.Catalog.Models;
using System;

namespace Service.Catalog.Dtos
{
	public class CourseDto
	{
		public string Id { get; set; }

		public string UserId { get; set; }

		public string CourseName { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public string Picture { get; set; }

		public DateTime DateTime { get; set; }

		public FeatureDto Feature { get; set; }

		public string CategoryId { get; set; }

		public CategoryDto Category { get; set; }
	}
}
