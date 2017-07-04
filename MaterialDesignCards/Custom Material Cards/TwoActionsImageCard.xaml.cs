using System.Windows.Input;
using Xamarin.Forms;

namespace MaterialDesignCards.CustomMaterialCards
{
    public partial class TwoActionsImageCard : Frame
    {
        public TwoActionsImageCard()
        {
            InitializeComponent();
        }

		private static ContentView DefaultContent = new ContentView() { Content = new Label() { IsVisible = false } };

		public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(TwoActionsImageCard), "");
		public string ImageSource
		{
			get
			{
				return (string)GetValue(ImageSourceProperty);
			}
			set
			{
				SetValue(ImageSourceProperty, value);
			}
		}

		public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(TwoActionsImageCard), "");
		public string Title
		{
			get
			{
				return (string)GetValue(TitleProperty);
			}
			set
			{
				SetValue(TitleProperty, value);
			}
		}

		public static readonly BindableProperty SubTitleProperty = BindableProperty.Create(nameof(SubTitle), typeof(string), typeof(TwoActionsImageCard), "");
		public string SubTitle
		{
			get
			{
				return (string)GetValue(SubTitleProperty);
			}
			set
			{
				SetValue(SubTitleProperty, value);
			}
		}

		public static readonly BindableProperty MainContentProperty = BindableProperty.Create(nameof(MainContent), typeof(View), typeof(TwoActionsImageCard), TwoActionsImageCard.DefaultContent);
		public View MainContent
		{
			get
			{
				var content_value = (View)GetValue(MainContentProperty);
				content_value.BindingContext = this.BindingContext;
				return content_value;
			}
			set
			{
				SetValue(MainContentProperty, value);
			}
		}

		public static readonly BindableProperty PrimaryActionTextProperty = BindableProperty.Create(nameof(PrimaryActionText), typeof(string), typeof(TwoActionsImageCard), "");
		public string PrimaryActionText
		{
			get
			{
				return (string)GetValue(PrimaryActionTextProperty);
			}
			set
			{
				SetValue(PrimaryActionTextProperty, value);
			}
		}

		public static readonly BindableProperty PrimaryActionProperty = BindableProperty.Create(nameof(PrimaryAction), typeof(ICommand), typeof(TwoActionsImageCard), new Command(() => { }));
		public ICommand PrimaryAction
		{
			get
			{
				return (ICommand)GetValue(PrimaryActionProperty);
			}
			set
			{
				SetValue(PrimaryActionProperty, value);
			}
		}

		public static readonly BindableProperty SecondaryActionTextProperty = BindableProperty.Create(nameof(SecondaryActionText), typeof(string), typeof(TwoActionsImageCard), "");
		public string SecondaryActionText
		{
			get
			{
				return (string)GetValue(SecondaryActionTextProperty);
			}
			set
			{
				SetValue(SecondaryActionTextProperty, value);
			}
		}

		public static readonly BindableProperty SecondaryActionProperty = BindableProperty.Create(nameof(SecondaryAction), typeof(ICommand), typeof(TwoActionsImageCard), new Command(() => { }));
		public ICommand SecondaryAction
		{
			get
			{
				return (ICommand)GetValue(SecondaryActionProperty);
			}
			set
			{
				SetValue(SecondaryActionProperty, value);
			}
		}
    }
}
