using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mvc.RazorTools.FontAwesome
{
	/// <summary>
	/// Defines the properties necessary to create a Font Awesome tag in an MVC Razor view.
	/// </summary>
	public partial class FaIcon : MvcRazorObject
	{
		/// <summary>
		/// Initializes a new empty instance of a <see cref="FaIcon"/> object. Note
		/// this empty version will not display any icon until the Id property is set.
		/// </summary>
		public FaIcon()
		{
			this.IncludeIdInHtml = false;
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="FaIcon"/> object with the
		/// specified Id. The Id represents the icon name in the CSS style sheet for Font Awesome.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		public FaIcon(string iconId)
			: this()
		{
			this.IconId = iconId;
		}

		/// <summary>
		/// Initializes a new instance of a <see cref="FaIcon"/> object with the
		/// specified Id and Unicode value. The Unicode value is for display purposes only and it
		/// not used by this library.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <param name="unicode">An <see cref="Int32"/> value representing the Unicode value of the font.</param>
		public FaIcon(string iconId, int unicode)
			: this(iconId)
		{
			this.Unicode = unicode;
		}

		internal FaIcon(string iconId, int unicode, bool locked, string name, FaLicenseType license, IList<string> freeStyles, IList<string> proStyles)
		{
			this.Id = iconId;
			this.IconId = iconId;
			this.Unicode = unicode;
			this.Name = name;
			this.License = license;
			this.FreeStyles = freeStyles;
			this.ProStyles = proStyles;
			this.Locked = locked;
		}

		private string _iconId = System.String.Empty;
		/// <summary>
		/// Gets/sets the CSS style sheet name of the icon this instance represents. 
		/// If the object is a predefined object then this value cannot be changed. 
		/// Read-only if this instanced is locked.
		/// </summary>
		public string IconId
		{
			get
			{
				return _iconId;
			}
			set
			{
				if (!this.Locked)
				{
					_iconId = value;
					this.UpdateClassAttribute($"fa-{_iconId}");
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		private int _unicode = 0;
		/// <summary>
		/// Gets/set an <see cref="Int32"/> value that represents the Unicode value of the font. Read-only 
		/// if this instanced is locked.
		/// </summary>
		public int Unicode
		{
			get
			{
				return _unicode;
			}
			set
			{
				if (!this.Locked)
				{
					_unicode = value;
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		/// <summary>
		/// Gets a hexadecimal representation of the Unicode value.
		/// </summary>
		public string HexCode
		{
			get
			{
				return this.Unicode.ToString("X4").ToLower();
			}
		}

		private FaLicenseType _license = FaLicenseType.None;
		/// <summary>
		/// Gets/sets the license type that is required for this icon.
		/// </summary>
		public FaLicenseType License
		{
			get
			{
				return _license;
			}
			set
			{
				if (!this.Locked)
				{
					_license = value;
				}
				else
				{
					throw new ModifyLockedInstanceException();
				}
			}
		}

		/// <summary>
		/// Gets the list of styles supported when using the free license.
		/// </summary>
		public IList<string> FreeStyles { get; private set; } = new string[0];

		/// <summary>
		/// Gets the list of styles supported when using the pro license.
		/// </summary>
		public IList<string> ProStyles { get; private set; } = new string[0];

		/// <summary>
		/// Returns True if this icon is an alias of another icon. Use the Hex Code or Unicode
		/// value to determine the equivalent icon.
		/// </summary>
		[Obsolete("This property will always return false.")]
		public bool IsAlias => false;

		/// <summary>
		/// Initializes and returns a new instance of a <see cref="FaIcon"/> object
		/// with the specified Id.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <returns>A newly initialized <see cref="FaIcon"/> object.</returns>
		public static FaIcon Create(string iconId)
		{
			return new FaIcon()
			{ 
				Id = iconId, 
				IconId = iconId 
			};
		}

		/// <summary>
		/// Initializes and returns a new instance of a <see cref="FaIcon"/> object
		/// with the specified Id and Unicode value.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <param name="unicode">A <see cref="Int32"/> value that represents the Unicode value of the font.</param>
		/// <returns>A newly initialized <see cref="FaIcon"/> object.</returns>
		public static FaIcon Create(string iconId, int unicode)
		{
			return new FaIcon()
			{ 
				Id = iconId, 
				IconId = iconId, 
				Unicode = unicode 
			};
		}

		/// <summary>
		/// Initializes and returns a new instance of a <see cref="FaIcon"/> object.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <param name="unicode">A <see cref="Int32"/> value that represents the Unicode value of the font.</param>
		/// <param name="locked">A value that indicates if the properties on this instance are locked or not.</param>
		/// <param name="name">A <see cref="String"/> that contains the name of this instance.</param>
		/// <param name="license">Indicates the type of license required to use this icon.</param>
		/// <param name="freeStyles">Lists the styles supported with the free license.</param>
		/// <param name="proStyles">Lists the styles supported with the pro license.</param>
		/// <returns>A newly initialized <see cref="FaIcon"/> object.</returns>
		internal static FaIcon Create(string iconId, int unicode, bool locked, string name, FaLicenseType license, IList<string> freeStyles, IList<string> proStyles)
		{
			return new FaIcon()
			{
				Id = iconId,
				IconId = iconId,
				Unicode = unicode,
				Locked = locked,
				Name = name,
				License = license,
				FreeStyles = freeStyles,
				ProStyles = proStyles
			};
		}

		/// <summary>
		/// Initializes and returns a new instance of a <see cref="FaIcon"/> object
		/// with the specified Id and custom class attributes.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <param name="classAttributes">A list of custom class attributes for this instance.</param>
		/// <returns>A newly initialized <see cref="FaIcon"/> object.</returns>
		public static FaIcon Create(string iconId, IDictionary<string, string> classAttributes)
		{
			FaIcon returnValue = new FaIcon(iconId);

			returnValue.MergeClassAttributes(classAttributes);

			return returnValue;
		}

		/// <summary>
		/// Initializes and returns a new instance of a <see cref="FaIcon"/> object
		/// with the specified Id, Unicode value and custom class attributes.
		/// </summary>
		/// <param name="iconId">The CSS style sheet name of the icon this instance represents.</param>
		/// <param name="unicode">A <see cref="Int32"/> value that represents the Unicode value of the font.</param>
		/// <param name="classAttributes">A list of custom class attributes for this instance.</param>
		/// <returns>A newly initialized <see cref="FaIcon"/> object.</returns>
		public static FaIcon Create(string iconId, int unicode, IDictionary<string, string> classAttributes)
		{
			FaIcon returnValue = new FaIcon(iconId, unicode);

			returnValue.MergeClassAttributes(classAttributes);

			return returnValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string OnInitializeHtmlTag()
		{
			return "i";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override object OnClone()
		{
			FaIcon returnValue = FaIcon.Create(this.IconId, this.Unicode);
			returnValue.Locked = false;
			returnValue.MergeClassAttributes(this.ClassAttributes);
			return returnValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string OnInitializeName()
		{
			return this.IconId;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		protected string ConvertId(string id)
		{
			string returnValue = String.Empty;

			if (Char.IsDigit(id.ToCharArray()[0]))
			{
				id = $"X{id}";
			}

			CultureInfo cultureInfo = CultureInfo.CurrentCulture;
			TextInfo textInfo = cultureInfo.TextInfo;
			returnValue = textInfo.ToTitleCase(id).Replace("-", String.Empty);

			return returnValue;
		}
	}
}