using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace AspNet.Identity.MongoDB {

	public class IdentityUserRole {
		[BsonRepresentation(BsonType.ObjectId)]
		[BsonElement(FieldNames.RoleId)]
		public String RoleId { get; set; }
		[BsonElement(FieldNames.Name)]
		public String Name { get; set; }

		public static class FieldNames
		{
		    public const String RoleId = nameof(RoleId);
		    public const String Name = nameof(Name);
		}
	}
}
