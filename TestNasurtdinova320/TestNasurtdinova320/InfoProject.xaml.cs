using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestNasurtdinova320
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoProject : ContentPage
    {
        public InfoProject()
        {
            InitializeComponent();
            infoFirst.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In et ultricies orci, in porta sem. Vestibulum in risus iaculis, porta orci at, " +
                "bibendum velit. Nam volutpat pulvinar feugiat. Suspendisse imperdiet scelerisque porttitor. Integer mauris nibh, varius nec sem at, molestie cursus enim. " +
                "Curabitur quis ipsum arcu. Ut ac accumsan dolor, sit amet molestie massa. In pharetra metus nec metus rutrum rhoncus. Quisque vestibulum dui dui, " +
                "nec posuere nunc condimentum ut. Nunc accumsan sagittis dolor eu imperdiet.";
            infoSecond.Text = "Phasellus non purus et ante convallis volutpat. Curabitur fringilla, ligula quis consequat feugiat, nibh justo condimentum diam, sit amet " +
                "tincidunt dui sapien ut ante. Integer pretium dui vitae magna interdum pellentesque. In ac ornare est. Donec congue volutpat nibh, sed pretium mi venenatis " +
                "vel. Donec rutrum elementum lectus, eu posuere libero commodo id. Pellentesque molestie sollicitudin velit et sagittis.";
            infoThird.Text = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nunc cursus quam ac mauris cursus pharetra." +
                " Nam quis pretium lorem. Phasellus erat nibh, tempus eget arcu et, malesuada malesuada nibh. Praesent semper nulla vel ligula pharetra, et fringilla " +
                "metus viverra. Morbi orci tortor, mattis eu arcu eu, tristique venenatis quam. Fusce facilisis vel est nec laoreet. In dictum felis nisl, ullamcorper " +
                "pulvinar enim volutpat et. Integer in nisl ut elit gravida maximus. Fusce nec lacus a massa cursus elementum quis commodo enim. Aliquam tincidunt, " +
                "velit ut sollicitudin laoreet, felis odio accumsan nisi, nec placerat nulla est quis lorem. Suspendisse sed sapien sit amet tellus viverra porttitor. " +
                "Nam nunc massa, tempus et velit a, volutpat semper ipsum.";
            infoFourth.Text = "Aliquam condimentum dolor sed condimentum finibus. In nec tincidunt magna. Proin suscipit mi non orci facilisis efficitur. Proin vel bibendum " +
                "urna, in sagittis turpis. Aliquam in tellus nec augue tempor viverra non eu nibh. Quisque porttitor dolor tortor, quis condimentum elit malesuada et. " +
                "Nulla facilisi. Aliquam erat volutpat. Nulla facilisi. Maecenas imperdiet euismod dapibus. Maecenas pharetra lectus eget feugiat aliquet.";
            infoFifth.Text = "Vestibulum maximus orci ac ligula sagittis fermentum. Phasellus felis dui, porta ac sapien nec, cursus egestas ante. Nam vehicula sed odio " +
                "id dapibus. Suspendisse ultrices mauris ut ipsum mollis, at porta orci fermentum. Aenean varius pretium ex eu commodo. Aenean luctus orci dui, et faucibus " +
                "nulla commodo sodales. Nunc ornare, turpis quis elementum maximus, libero sem semper arcu, nec vulputate nunc massa a ante. Curabitur eu iaculis metus. " +
                "Aliquam venenatis iaculis quam. Aliquam ac nibh cursus, aliquam dui id, convallis leo. Fusce est erat, convallis eget molestie eu, accumsan nec felis.";
        }
    }
}