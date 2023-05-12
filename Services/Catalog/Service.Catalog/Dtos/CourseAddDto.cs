using System;

namespace Service.Catalog.Dtos
{
	public class CourseAddDto
	{
		public string UserId { get; set; }

		public string CourseName { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public string Picture { get; set; }

		public FeatureDto Feature { get; set; }

		public string CategoryId { get; set; }

	}
}
