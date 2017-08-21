using Microsoft.AspNet.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace AspNet.Identity.MongoDB {

	public class IdentityUserLogin {
		[BsonElement(FieldNames.LoginProvider)]
		public String LoginProvider { get; set; }
		[BsonElement(FieldNames.ProviderKey)]
		public String ProviderKey { get; set; }

		public static class FieldNames {
			public const String LoginProvider = nameof(LoginProvider);
		    public const String ProviderKey = nameof(ProviderKey);
		}
	}
}
