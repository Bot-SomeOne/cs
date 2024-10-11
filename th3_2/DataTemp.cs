using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using th3_2.Models;
//


namespace th3_2
{
    public class DataTemp
    {
        private static BaiTapDienTu baiTapDienTu1 = new BaiTapDienTu(
            "I have an[1] and a[2].My favorite pet is a[3] and my friend's pet is a [4]. In the zoo, we saw an [5], a [6], and a [7] tree. I wore my [8] and ate some [9] while watching a [10] on display.",
            "I have an [1]apple and a [2]banana.My favorite pet is a [3]cat and my friend's pet is a [4]dog. In the zoo, we saw an [5]elephant, a [6]fish, and a [7]grape tree. I wore my [8]hat and ate some [9]ice while watching a [10]jacket on display.",
            new List<string> { "apple", "banana", "cat", "dog", "elephant", "fish", "grape", "hat", "ice", "jacket" }
        );

        private static BaiTapDienTu baiTapDienTu2 = new BaiTapDienTu(
            "The[1] is the king of the jungle and the [2] is known to be the tallest animal. I saw a [3] swimming in the water and a [4] flying high in the sky. At the aquarium, we admired the [5] and the [6]. Later, we walked through a [7] forest and found some [8] growing along the path. We stopped by a stand to eat [9] while listening to music from a [10].",
            "The [1]lion is the king of the jungle and the [2]giraffe is known to be the tallest animal. I saw a [3]dolphin swimming in the water and a [4]bird flying high in the sky. At the aquarium, we admired the [5]shark and the [6]octopus. Later, we walked through a [7]bamboo forest and found some [8]berries growing along the path. We stopped by a stand to eat [9]popcorn while listening to music from a [10]guitar.",
            new List<string> { "lion", "giraffe", "dolphin", "bird", "shark", "octopus", "bamboo", "berries", "popcorn", "guitar" }
        );

        private static BaiTapDienTu baiTapDienTu3 = new BaiTapDienTu(
            "In the morning, I usually have a [1] and a cup of [2]. I take my [3] to school and use my [4] during class. After school, I play [5] with my friends and then do my [6] at home. On weekends, I like to go [7] with my family, and sometimes we eat [8] at a restaurant. My favorite color is [9], and I always wear my [10] when I go out.",
            "In the morning, I usually have a [1]sandwich and a cup of [2]coffee. I take my [3]backpack to school and use my [4]laptop during class. After school, I play [5]soccer with my friends and then do my [6]homework at home. On weekends, I like to go [7]shopping with my family, and sometimes we eat [8]pizza at a restaurant. My favorite color is [9]blue, and I always wear my [10]jacket when I go out.",
            new List<string> { "sandwich", "coffee", "backpack", "laptop", "soccer", "homework", "shopping", "pizza", "blue", "jacket" }
        );

        private static BaiTapDienTu baiTapDienTu4 = new BaiTapDienTu(
            "During the summer vacation, we went to the [1] and swam in the [2]. I built a [3] with my friends and collected [4] along the shore. In the evening, we watched the [5] set and had a barbecue with [6] and [7]. We stayed in a [8] near the beach and fell asleep to the sound of the [9] crashing on the shore. The next day, we explored a nearby [10].",
            "During the summer vacation, we went to the [1]beach and swam in the [2]ocean. I built a [3]sandcastle with my friends and collected [4]shells along the shore. In the evening, we watched the [5]sun set and had a barbecue with [6]sausages and [7]corn. We stayed in a [8]cottage near the beach and fell asleep to the sound of the [9]waves crashing on the shore. The next day, we explored a nearby [10]forest.",
            new List<string> { "beach", "ocean", "sandcastle", "shells", "sun", "sausages", "corn", "cottage", "waves", "forest" }
        );

        private static BaiTapDienTu baiTapDienTu5 = new BaiTapDienTu(
            "In the city, you can see tall [1] and busy [2]. People often ride the [3] to work, and there are many [4] selling food on the streets. I like to visit the [5] on weekends and enjoy a [6] in the park. There is always something happening, from [7] to street performances. At night, the [8] are bright, and you can hear the sounds of [9] in the distance. My favorite place to relax is by the [10].",
            "In the city, you can see tall [1]buildings and busy [2]streets. People often ride the [3]bus to work, and there are many [4]vendors selling food on the streets. I like to visit the [5]museum on weekends and enjoy a [6]picnic in the park. There is always something happening, from [7]concerts to street performances. At night, the [8]lights are bright, and you can hear the sounds of [9]traffic in the distance. My favorite place to relax is by the [10]fountain.",
            new List<string> { "buildings", "streets", "bus", "vendors", "museum", "picnic", "concerts", "lights", "traffic", "fountain" }
        );

        // Getter singleton pattern
        public static BaiTapDienTu BaiTapDienTu1 { get => baiTapDienTu1; }
        public static BaiTapDienTu BaiTapDienTu2 { get => baiTapDienTu2; }
        public static BaiTapDienTu BaiTapDienTu3 { get => baiTapDienTu3; }
        public static BaiTapDienTu BaiTapDienTu4 { get => baiTapDienTu4; }
        public static BaiTapDienTu BaiTapDienTu5 { get => baiTapDienTu5; }
    }
}
