using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Twitterizer.Entities
{
	[Serializable]
	public class TwitterEntityCollection : Collection<TwitterEntity>
	{
		public TwitterEntityCollection()
		{
		}

		internal class Converter : JsonConverter
		{
			public Converter()
			{
			}

			public override bool CanConvert(Type objectType)
			{
				return objectType == typeof(TwitterEntityCollection);
			}

			public TwitterMediaEntity parseMediaEntity(JsonReader reader)
			{
				TwitterEntityCollection.Converter.u003cu003ec__DisplayClassa variable = null;
				TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8 variable1 = null;
				TwitterMediaEntity twitterMediaEntity;
				TwitterMediaEntity.MediaSize.MediaSizeResizes mediaSizeResize;
				try
				{
					if (reader.TokenType == JsonToken.StartObject)
					{
						TwitterMediaEntity mediaSizes = new TwitterMediaEntity();
						int depth = reader.Depth;
						while (true)
						{
							if ((!reader.Read() ? true : reader.Depth < depth))
							{
								break;
							}
							if (reader.TokenType == JsonToken.PropertyName)
							{
								string value = reader.Value as string;
								if (!string.IsNullOrEmpty(value))
								{
									string str = value;
									if (str != null)
									{
										switch (str)
										{
											case "type":
											{
												mediaSizes.MediaType = (string.IsNullOrEmpty((string)reader.Value) ? TwitterMediaEntity.MediaTypes.Unknown : TwitterMediaEntity.MediaTypes.Photo);
												break;
											}
											case "sizes":
											{
												mediaSizes.Sizes = new List<TwitterMediaEntity.MediaSize>();
												break;
											}
											case "large":
											case "medium":
											case "small":
											case "thumb":
											{
												if (reader.TokenType == JsonToken.PropertyName)
												{
													TwitterMediaEntity.MediaSize mediaSize = new TwitterMediaEntity.MediaSize();
													str = (string)reader.Value;
													if (str == null)
													{
													}
													else if (str == "large")
													{
														mediaSize.Size = TwitterMediaEntity.MediaSize.MediaSizes.Large;
													}
													else if (str == "medium")
													{
														mediaSize.Size = TwitterMediaEntity.MediaSize.MediaSizes.Medium;
													}
													else if (str == "small")
													{
														mediaSize.Size = TwitterMediaEntity.MediaSize.MediaSizes.Small;
													}
													else
													{
														if (str != "thumb")
														{
															goto Label4;
														}
														mediaSize.Size = TwitterMediaEntity.MediaSize.MediaSizes.Thumb;
													}
												Label4:
													int num = reader.Depth;
													while (true)
													{
														if ((!reader.Read() ? true : num >= reader.Depth))
														{
															break;
														}
														if (reader.TokenType == JsonToken.PropertyName)
														{
															this.ReadFieldValue<TwitterMediaEntity.MediaSize, int>(reader, "h", mediaSize, Expression.Lambda<Func<int>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClassa).GetField("newSize").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity.MediaSize).GetMethod("get_Height").MethodHandle)), new ParameterExpression[0]));
															this.ReadFieldValue<TwitterMediaEntity.MediaSize, int>(reader, "w", mediaSize, Expression.Lambda<Func<int>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClassa).GetField("newSize").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity.MediaSize).GetMethod("get_Width").MethodHandle)), new ParameterExpression[0]));
															if ((reader.TokenType != JsonToken.PropertyName ? false : (string)reader.Value == "resize"))
															{
																reader.Read();
																TwitterMediaEntity.MediaSize mediaSize1 = mediaSize;
																if (string.IsNullOrEmpty((string)reader.Value))
																{
																	mediaSizeResize = TwitterMediaEntity.MediaSize.MediaSizeResizes.Unknown;
																}
																else
																{
																	mediaSizeResize = ((string)reader.Value == "fit" ? TwitterMediaEntity.MediaSize.MediaSizeResizes.Fit : TwitterMediaEntity.MediaSize.MediaSizeResizes.Crop);
																}
																mediaSize1.Resize = mediaSizeResize;
															}
														}
													}
													mediaSizes.Sizes.Add(mediaSize);
													break;
												}
												else
												{
													break;
												}
											}
											case "indices":
											{
												reader.Read();
												reader.Read();
												mediaSizes.StartIndex = Convert.ToInt32((long)reader.Value);
												reader.Read();
												mediaSizes.EndIndex = Convert.ToInt32((long)reader.Value);
												break;
											}
											default:
											{
												goto Label3;
											}
										}
									}
									else
									{
									}
								Label3:
									this.ReadFieldValue<TwitterMediaEntity, decimal>(reader, "id", mediaSizes, Expression.Lambda<Func<decimal>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity).GetMethod("get_Id").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "id_str", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity).GetMethod("get_IdString").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "media_url", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity).GetMethod("get_MediaUrl").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "media_url_https", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMediaEntity).GetMethod("get_MediaUrlSecure").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "url", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_Url").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "display_url", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_DisplayUrl").MethodHandle)), new ParameterExpression[0]));
									this.ReadFieldValue<TwitterMediaEntity, string>(reader, "expanded_url", mediaSizes, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable1), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass8).GetField("entity").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_ExpandedUrl").MethodHandle)), new ParameterExpression[0]));
								}
							}
						}
						twitterMediaEntity = mediaSizes;
					}
					else
					{
						twitterMediaEntity = null;
					}
				}
				catch
				{
					twitterMediaEntity = null;
				}
				return twitterMediaEntity;
			}

			private bool ReadFieldValue<T>(JsonReader reader, string fieldName, ref T result)
			{
				bool flag;
				try
				{
					if (reader.TokenType != JsonToken.PropertyName)
					{
						flag = false;
					}
					else if (!((string)reader.Value != fieldName))
					{
						reader.Read();
						if (!(reader.ValueType == typeof(T)))
						{
							result = (T)Convert.ChangeType(reader.Value, typeof(T));
						}
						else
						{
							result = (T)reader.Value;
						}
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				catch
				{
					flag = false;
				}
				return flag;
			}

			private void ReadFieldValue<TSource, TProperty>(JsonReader reader, string fieldName, TSource source, Expression<Func<TProperty>> property)
			where TSource : class
			{
				try
				{
					if ((reader == null ? false : source != null))
					{
						PropertyInfo member = (PropertyInfo)((MemberExpression)property.Body).Member;
						TProperty value = (TProperty)member.GetValue(source, null);
						if (this.ReadFieldValue<TProperty>(reader, fieldName, ref value))
						{
							member.SetValue(source, value, null);
						}
					}
				}
				catch
				{
				}
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0 variable = null;
				TwitterEntityCollection twitterEntityCollection = existingValue as TwitterEntityCollection;
				if (twitterEntityCollection == null)
				{
					twitterEntityCollection = new TwitterEntityCollection();
				}
				int depth = reader.Depth;
				string empty = string.Empty;
				TwitterEntity twitterUrlEntity = null;
				try
				{
					if (reader.TokenType == JsonToken.StartArray)
					{
						reader.Read();
					}
					while (true)
					{
						if ((!reader.Read() ? true : reader.Depth <= depth))
						{
							break;
						}
						if ((reader.TokenType != JsonToken.PropertyName ? true : reader.Depth != depth + 1))
						{
							string str = empty;
							if (str != null)
							{
								if (str == "urls")
								{
									if (reader.TokenType == JsonToken.StartObject)
									{
										twitterUrlEntity = new TwitterUrlEntity();
									}
									if (twitterUrlEntity as TwitterUrlEntity != null)
									{
										this.ReadFieldValue<TwitterEntity, string>(reader, "url", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tue").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_Url").MethodHandle)), new ParameterExpression[0]));
										this.ReadFieldValue<TwitterEntity, string>(reader, "display_url", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tue").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_DisplayUrl").MethodHandle)), new ParameterExpression[0]));
										this.ReadFieldValue<TwitterEntity, string>(reader, "expanded_url", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tue").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterUrlEntity).GetMethod("get_ExpandedUrl").MethodHandle)), new ParameterExpression[0]));
									}
								}
								else if (str == "user_mentions")
								{
									if (reader.TokenType == JsonToken.StartObject)
									{
										twitterUrlEntity = new TwitterMentionEntity();
									}
									if (twitterUrlEntity as TwitterMentionEntity != null)
									{
										this.ReadFieldValue<TwitterEntity, string>(reader, "screen_name", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tme").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMentionEntity).GetMethod("get_ScreenName").MethodHandle)), new ParameterExpression[0]));
										this.ReadFieldValue<TwitterEntity, string>(reader, "name", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tme").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMentionEntity).GetMethod("get_Name").MethodHandle)), new ParameterExpression[0]));
										this.ReadFieldValue<TwitterEntity, decimal>(reader, "id", twitterUrlEntity, Expression.Lambda<Func<decimal>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("tme").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterMentionEntity).GetMethod("get_UserId").MethodHandle)), new ParameterExpression[0]));
									}
								}
								else if (str == "hashtags")
								{
									if (reader.TokenType == JsonToken.StartObject)
									{
										twitterUrlEntity = new TwitterHashTagEntity();
									}
									if (twitterUrlEntity as TwitterHashTagEntity != null)
									{
										this.ReadFieldValue<TwitterEntity, string>(reader, "text", twitterUrlEntity, Expression.Lambda<Func<string>>(Expression.Property(Expression.Field(Expression.Constant(variable), FieldInfo.GetFieldFromHandle(typeof(TwitterEntityCollection.Converter.u003cu003ec__DisplayClass0).GetField("the").FieldHandle)), (MethodInfo)MethodBase.GetMethodFromHandle(typeof(TwitterHashTagEntity).GetMethod("get_Text").MethodHandle)), new ParameterExpression[0]));
									}
								}
								else if (str == "media")
								{
									reader.Read();
									twitterUrlEntity = this.parseMediaEntity(reader);
								}
							}
							if ((reader.TokenType != JsonToken.PropertyName || !((string)reader.Value == "indices") ? false : twitterUrlEntity != null))
							{
								reader.Read();
								reader.Read();
								twitterUrlEntity.StartIndex = Convert.ToInt32((long)reader.Value);
								reader.Read();
								twitterUrlEntity.EndIndex = Convert.ToInt32((long)reader.Value);
							}
							if ((reader.TokenType != JsonToken.EndObject || twitterUrlEntity == null ? twitterUrlEntity is TwitterMediaEntity : true))
							{
								twitterEntityCollection.Add(twitterUrlEntity);
								twitterUrlEntity = null;
							}
						}
						else
						{
							empty = (string)reader.Value;
						}
					}
				}
				catch
				{
				}
				return twitterEntityCollection;
			}

			private static void WriteEntity<T>(JsonWriter writer, IEnumerable<T> entities, string entityName, Action<JsonWriter, T> detailsAction)
			where T : TwitterEntity
			{
				writer.WritePropertyName(entityName);
				writer.WriteStartArray();
				foreach (T entity in entities)
				{
					writer.WriteStartObject();
					writer.WritePropertyName("indices");
					writer.WriteStartArray();
					writer.WriteValue(entity.StartIndex);
					writer.WriteValue(entity.EndIndex);
					writer.WriteEndArray();
					detailsAction(writer, entity);
					writer.WriteEndObject();
				}
				writer.WriteEndArray();
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
				TwitterEntityCollection twitterEntityCollection = (TwitterEntityCollection)value;
				writer.WriteStartObject();
				TwitterEntityCollection.Converter.WriteEntity<TwitterHashTagEntity>(writer, twitterEntityCollection.OfType<TwitterHashTagEntity>().ToList<TwitterHashTagEntity>(), "hashtags", (JsonWriter w, TwitterHashTagEntity e) => {
					w.WritePropertyName("text");
					w.WriteValue(e.Text);
				});
				TwitterEntityCollection.Converter.WriteEntity<TwitterMentionEntity>(writer, twitterEntityCollection.OfType<TwitterMentionEntity>().ToList<TwitterMentionEntity>(), "user_mentions", (JsonWriter w, TwitterMentionEntity e) => {
					w.WritePropertyName("screen_name");
					w.WriteValue(e.ScreenName);
					w.WritePropertyName("name");
					w.WriteValue(e.Name);
					w.WritePropertyName("id");
					w.WriteValue(e.UserId);
				});
				TwitterEntityCollection.Converter.WriteEntity<TwitterUrlEntity>(writer, twitterEntityCollection.OfType<TwitterUrlEntity>().ToList<TwitterUrlEntity>(), "urls", (JsonWriter w, TwitterUrlEntity e) => {
					w.WritePropertyName("url");
					w.WriteValue(e.Url);
					w.WritePropertyName("display_url");
					w.WriteValue(e.DisplayUrl);
					w.WritePropertyName("expanded_url");
					w.WriteValue(e.ExpandedUrl);
				});
				TwitterEntityCollection.Converter.WriteEntity<TwitterMediaEntity>(writer, twitterEntityCollection.OfType<TwitterMediaEntity>().ToList<TwitterMediaEntity>(), "media", new Action<JsonWriter, TwitterMediaEntity>(TwitterEntityCollection.Converter.WriteMediaEntity));
				writer.WriteEndObject();
			}

			private static void WriteMediaEntity(JsonWriter w, TwitterMediaEntity e)
			{
				w.WritePropertyName("type");
				switch (e.MediaType)
				{
					case TwitterMediaEntity.MediaTypes.Unknown:
					{
						w.WriteNull();
						break;
					}
					case TwitterMediaEntity.MediaTypes.Photo:
					{
						w.WriteValue("photo");
						break;
					}
				}
				w.WritePropertyName("sizes");
				w.WriteStartObject();
				foreach (TwitterMediaEntity.MediaSize size in e.Sizes)
				{
					w.WritePropertyName(size.Size.ToString().ToLower());
					w.WriteStartObject();
					w.WritePropertyName("h");
					w.WriteValue(size.Height);
					w.WritePropertyName("w");
					w.WriteValue(size.Width);
					w.WritePropertyName("resize");
					w.WriteValue((size.Resize == TwitterMediaEntity.MediaSize.MediaSizeResizes.Fit ? "fit" : "crop"));
					w.WriteEndObject();
				}
				w.WriteEndObject();
				w.WritePropertyName("id");
				w.WriteValue(e.Id);
				w.WritePropertyName("id_str");
				w.WriteValue(e.IdString);
				w.WritePropertyName("media_url");
				w.WriteValue(e.MediaUrl);
				w.WritePropertyName("media_url_https");
				w.WriteValue(e.MediaUrlSecure);
				w.WritePropertyName("url");
				w.WriteValue(e.Url);
				w.WritePropertyName("display_url");
				w.WriteValue(e.DisplayUrl);
				w.WritePropertyName("expanded_url");
				w.WriteValue(e.ExpandedUrl);
			}
		}
	}
}