using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace AutoFixture.Examples.Tests
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute()
            :base(() => new Fixture()
                .Customize(new AutoMoqCustomization()))
        {

        }
    }
}
