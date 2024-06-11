﻿using GraphQL.Types;
using GraphQLApi.Data;

namespace GraphQLApi.Types
{
    public class RatingType : ObjectGraphType<Rating>
	{


		public RatingType()
		{
			Name = "Rating";

			Field(x => x.Id, type: typeof(IdGraphType)).Description("Rating ID.");
			// below are scalar types so no need to specify type
			Field(x => x.CourseId);
			Field(x => x.StudentName);
			Field(x => x.Review);
			Field(x => x.StarValue);
	}



	}
}
