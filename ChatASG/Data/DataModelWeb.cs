

namespace ChatASG.Data
{

public class Museum{

   public static readonly  string BaseColor="color:rgb(177 110 51) !important;";
      public static readonly  string BaseBKColor="background:rgb(177 110 51) !important;";

   public static string []IMNEWS={
    "m1.jpeg",
    "m2.jpeg",
    "m3.jpeg",
    "m5.jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (2).jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (3).jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (4).jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (5).jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (6).jpeg",
    "WhatsApp Image 2024-03-16 at 2.12.59 PM (7).jpeg"
    };
        public readonly static List<string> MP = new List<string>();
        public readonly static  List<Section> Sections=new List<Section>();
   public static Section? GetSectionById(string id){
    
    foreach(var s in Sections)
        if (s.Id==id)
            return s;
     
    
    return null;
   }

   public static List<Section> getItems(int s,int e){

    List<Section> ss=new List<Section>();
    for(int i=s;i<Sections.Count&&i<e;i++)
        ss.Add(Sections[i]);
    return ss;

   }

   public static List<Item> getRoundItems(){
    Random random = new Random();
    int i = random.Next(0, Sections.Count);
    List<Item> items=new List<Item>();
   
    return Sections[i].Items;
   }

   public static async Task Load(){

     SeedData();
   }
   private static void SeedData(){


     for(int i = 1; i <= 16; i++)
            {
                MP.Add("MP/M" + i + ".JPEG");
            }
     AddSection();


   }
   
   private  static void AddSection(){
    //  Sections?.Add(new Section{
    //         Name = "المجلس التراثي لاستقبال الضيوف",
    //         Description = "مجلس تقليدي يستخدم لاستقبال الضيوف. يتميز بتصميمه النجدي الأصيل وديكوره البسيط.",
    //         Image = "images/mmmmp.mp4",
    //         Items = new List<Item>()
    //         {
    //             new Item
    //             {
    //                 Name = "سجادة",
    //                 Description = "سجادة مصنوعة من الصوف الطبيعي.",
    //                 Image = "images/car.jpeg"
    //             },
    //             new Item
    //             {
    //                 Name = "مخدات",
    //                 Description = "مجموعة من المخدات المزينة بتطريزات تقليدية.",
    //                 Image = "images/car.jpeg"
    //             },
    //             new Item
    //             {
    //                 Name = "دلة القهوة",
    //                 Description = "دلة قهوة تقليدية مصنوعة من النحاس.",
    //                 Image = "images/car.jpeg"
    //             }
    //         }
    //     });


         Sections?.Add(new Section
{
    Name = "كراج السيارات القديمة",
    Description = " يعرض هذا القسم مجموعة من السيارات القديمة التي امتلكها صاحب المتحف . بما في ذلك رنج روفر مديل 84 كانت لوالد صاحب المتحف الامير سعود الفغم رحمه الله",
    Image = "images/s1/V.mp4", // استبدل بصوره حقيقية
    Items = new List<Item>()
    {
        new Item
        {
            Name = "فلوكس واجن - بيتل",
            Description = "أول سيارة استخدمها صاحب المتحف.",
            Image = "images/s1/car1.jpeg" // استبدل بصوره حقيقية
        },
        new Item
        {
            Name = "لاند كروزر",
            Description = "أول جيب امتلكه صاحب المتحف - موديل 69.",
            Image = "images/s1/car2.jpeg" // استبدل بصوره حقيقية
        },
        // أضف المزيد من السيارات بنفس الهيكل

        new Item
        {
            Name = "هاف فورد",
            Description = "موديل 66.",
            Image = "images/s1/car3.jpeg" // استبدل بصوره حقيقية
        },
        new Item
        {
            Name = "رنج روفر",
            Description = "موديل 84، كانت لوالد صاحب المتحف الأمير سعود الفغم رحمه الله.",
            Image = "images/s1/car4.jpeg" // استبدل بصوره حقيقية
        },
    }
});


Section exhibitionHallSection = new Section();

// Set section properties
exhibitionHallSection.Name = "صالة العرض";
exhibitionHallSection.Description = "صالة عرض تحتوي على مجموعة من المقتنيات الأثرية من مختلف المجالات، مثل التنقل والفلاحة، بالإضافة إلى مجموعات من الفخاريات والجلديات والمعادن.";
exhibitionHallSection.Image = "images/s2/V.mp4"; // Replace with actual image URL

// Add individual exhibits as Item objects to the Items list
exhibitionHallSection.Items.Add(new Item
{
    Name = "الألوان في الاستخدامات اليومية",
    Description = "عرض للألوان التي استخدمت في مختلف الاستخدامات اليومية خلال المئة عام الماضية.",
    Image = "images/m1.jpeg"
});

exhibitionHallSection.Items.Add(new Item
{
    Name = "أدوات التنقل والفلاحة",
    Description = "عرض لأدوات التنقل والفلاحة التي استخدمت في الجزيرة العربية خلال المئة عام الماضية.",
    Image = "images/m2.jpeg"
});

// Add more exhibits following the same structure

exhibitionHallSection.Items.Add(new Item
{
    Name = "الفخاريات",
    Description = "مجموعة من الفخاريات من مختلف الحضارات العربية.",
    Image = "images/m3.jpeg"
});

exhibitionHallSection.Items.Add(new Item
{
    Name = "الجلديات والمعادن",
    Description = "مجموعة من الأدوات المصنوعة من الجلد والمعادن من مختلف الحضارات العربية.",
    Image = "images/m4.jpeg"
});

exhibitionHallSection.Items.Add(new Item
{
    Name = "الأحجار والعملات النادرة",
    Description = "مجموعة من الأحجار والعملات النادرة التي استخدمت في الجزيرة العربية خلال المئة عام الماضية.",
    Image = "images/m5.jpeg"
});

exhibitionHallSection.Items.Add(new Item
{
    Name = "الأجهزة القديمة",
    Description = "عرض للأجهزة التي استخدمت منذ بدايات القرن الماضي.",
    Image = "images/m6.jpeg"
});

// Add the exhibition hall section to the Sections list
Sections?.Add(exhibitionHallSection);

// Create a new Section object for the grocery store
Section groceryStoreSection = new Section();

// Set section properties
groceryStoreSection.Name = "  البقالة";
groceryStoreSection.Description = "أول بقالة تم افتتاحها في مركز السعيرة التجاري، أول مركز تجاري تم إنشاؤه في مدينة السعيرة. كان مالكها بجاد الصهيبي رحمه الله، وتعرض البقالة بضائع قديمة.";
groceryStoreSection.Image = "images/s3/V.mp4"; // Replace with actual image URL

// Add individual items as Item objects to the Items list
groceryStoreSection.Items.Add(new Item
{
    Name = "أدوات المطبخ",
    Description = "عرض لأدوات المطبخ التي استخدمت في الماضي.",
    Image = "images/m1.jpeg"
});

groceryStoreSection.Items.Add(new Item
{
    Name = "الأطعمة",
    Description = "عرض للأطعمة التي كانت تباع في البقالة في الماضي.",
    Image = "images/m2.jpeg"
});

// Add more items following the same structure

groceryStoreSection.Items.Add(new Item
{
    Name = "العبوات",
    Description = "عرض للعبوات التي استخدمت لتعبئة البضائع في الماضي.",
    Image = "images/m3.jpeg"
});

groceryStoreSection.Items.Add(new Item
{
    Name = "الأدوات المنزلية",
    Description = "عرض للأدوات المنزلية التي كانت تباع في البقالة في الماضي.",
    Image = "images/m4.jpeg"
});

// Add the grocery store section to the Sections list
Sections?.Add(groceryStoreSection);
// Create a new Section object for the customs and traditions section
Section customsAndTraditionsSection = new Section();

// Set section properties
customsAndTraditionsSection.Name = "قسم العادات والتقاليد";
customsAndTraditionsSection.Description = "يعرض هذا القسم مجموعة من النماذج التي تعكس العادات والتقاليد في المنطقة قبل 50 عامًا، بما في ذلك:";
customsAndTraditionsSection.Image = "images/s4/V.mp4"; // Replace with actual image URL

// Add individual items as Item objects to the Items list
customsAndTraditionsSection.Items.Add(new Item
{
    Name = "اللباس النجدي",
    Description = "عرض للباس النجدي للرجل والمرأة قبل 50 عامًا.",
    Image = "images/m1.jpeg"
});

customsAndTraditionsSection.Items.Add(new Item
{
    Name = "الحلي القديمة",
    Description = "عرض لمجموعة من الحلي القديمة التي كانت ترتديها النساء في الماضي.",
    Image = "images/m2.jpeg"
});

// Add more items following the same structure

customsAndTraditionsSection.Items.Add(new Item
{
    Name = "الأدوات المنزلية",
    Description = "عرض للأدوات المنزلية التي استخدمتها العائلات في الماضي.",
    Image = "images/m3.jpeg"
});

customsAndTraditionsSection.Items.Add(new Item
{
    Name = "أسلحة الدفاع عن النفس",
    Description = "عرض لأنواع مختلفة من أسلحة الدفاع عن النفس التي استخدمتها العائلات في الماضي، مثل الفأس والسكين والرمح والشلفاء والسيف والعجره والمشعاب والعصا والنبل والسهم والدرع والطاسه والجوخ والدرقاء.",
    Image = "https://example.com/self-defense-weapons-exhibit-image.jpg"
});

customsAndTraditionsSection.Items.Add(new Item
{
    Name = "الأسلحة النارية",
    Description = "عرض لأول الأسلحة النارية التي استخدمت في المنطقة، بما في ذلك البنادق التي استخدمت في الحرب العالمية الأولى والثانية.",
    Image = "images/WhatsApp Image 2024-03-16 at 2.12.59 PM (4).jpeg"
});

// Add the customs and traditions section to the Sections list
Sections?.Add(customsAndTraditionsSection);
// Create a new Section object for the living room section
Section livingRoomSection = new Section();

// Set section properties
livingRoomSection.Name = "قسم غرفة المعيشة";
livingRoomSection.Description = "يعرض هذا القسم صورة مبسطة تعكس الطابع النجدي للحقبة الماضية، وتُظهر كيف كانت الغرف القديمة في بيوت السعيرة.";
livingRoomSection.Image = "images/s5/V.mp4"; // Replace with actual image URL

// Add individual items as Item objects to the Items list
livingRoomSection.Items.Add(new Item
{
    Name = "السجادة",
    Description = "سجادة مصنوعة من الصوف الطبيعي.",
    Image = "https://example.com/carpet-image.jpg"
});

livingRoomSection.Items.Add(new Item
{
    Name = "المخدات",
    Description = "مجموعة من المخدات المزينة بتطريزات تقليدية.",
    Image = "https://example.com/pillows-image.jpg"
});

// Add more items following the same structure

livingRoomSection.Items.Add(new Item
{
    Name = "الدلة",
    Description = "دلة قهوة تقليدية مصنوعة من النحاس.",
    Image = "https://example.com/coffee-pot-image.jpg"
});

livingRoomSection.Items.Add(new Item
{
    Name = "الأدوات المنزلية",
    Description = "عرض لأدوات منزلية تقليدية مثل الأواني الفخارية والجلديات.",
    Image = "https://example.com/household-items-image.jpg"
});

// Add the living room section to the Sections list
Sections?.Add(livingRoomSection);

// Create a new Section object for the classroom model section
Section classroomModelSection = new Section();

// Set section properties
classroomModelSection.Name = "قسم نموذج مبسط لطريقة الصفوف الدراسية";
classroomModelSection.Description = "يعرض هذا القسم نموذجًا مبسطًا لطريقة الصفوف الدراسية في الماضي، بالإضافة إلى عرض شهادات الشكر والتقدير التي حصل عليها صاحب المتحف خلال مسيرته التعليمية.";
classroomModelSection.Image = "https://example.com/classroom-model-image.jpg"; // Replace with actual image URL

// Add individual items as Item objects to the Items list
classroomModelSection.Items.Add(new Item
{
    Name = "السبورة",
    Description = "سبورة تقليدية مصنوعة من الخشب.",
    Image = "https://example.com/blackboard-image.jpg"
});

classroomModelSection.Items.Add(new Item
{
    Name = "المقاعد",
    Description = "مجموعة من المقاعد الخشبية التي كان يجلس عليها الطلاب في الماضي.",
    Image = "https://example.com/desks-image.jpg"
});

// Add more items following the same structure

classroomModelSection.Items.Add(new Item
{
    Name = "الكتب المدرسية",
    Description = "عرض للكتب المدرسية التي استخدمت في الماضي.",
    Image = "https://example.com/textbooks-image.jpg"
});

classroomModelSection.Items.Add(new Item
{
    Name = "شهادات الشكر والتقدير",
    Description = "عرض لأكثر من 120 شهادة شكر وتقدير حصل عليها صاحب المتحف في مجالات مختلفة من الأنشطة التعليمية.",
    Image = "https://example.com/certificates-image.jpg"
});

// Add the classroom model section to the Sections list
Sections?.Add(classroomModelSection);

// Create a new Section object for the Gulf War room section
Section gulfWarRoomSection = new Section();

// Set section properties
gulfWarRoomSection.Name = "قسم غرفة حرب الخليج";
gulfWarRoomSection.Description = "يعرض هذا القسم أهم الأحداث التي مرت على السعيرة خلال حرب الخليج، حيث كانت المدينة وأهلها داعماً لوجستياً للقوات المشتركة، كما استقبلت السعيرة العديد من الكويتيين الذين نزحوا من بلادهم خلال الحرب.";
gulfWarRoomSection.Image = "images/s6/V.mp4"; // Replace with actual image URL

// Add individual items as Item objects to the Items list
gulfWarRoomSection.Items.Add(new Item
{
    Name = "صور من حرب الخليج",
    Description = "عرض لصور من حرب الخليج تُظهر كيف استقبلت السعيرة الكويتيين وقوات التحالف.",
    Image = "https://example.com/gulf-war-photos-image.jpg"
});

gulfWarRoomSection.Items.Add(new Item
{
    Name = "أدوات استخدمت في حرب الخليج",
    Description = "عرض لأدوات استخدمت في حرب الخليج مثل الخوذات والبنادق.",
    Image = "https://example.com/gulf-war-equipment-image.jpg"
});

// Add more items following the same structure

gulfWarRoomSection.Items.Add(new Item
{
    Name = "شهادات شكر وتقدير",
    Description = "عرض لشهادات الشكر والتقدير التي حصل عليها أهالي السعيرة على مساهمتهم في حرب الخليج.",
    Image = "https://example.com/gulf-war-certificates-image.jpg"
});

gulfWarRoomSection.Items.Add(new Item
{
    Name = "قصص من حرب الخليج",
    Description = "عرض لقصص من حرب الخليج تُظهر كرم الضيافة وكرم أهالي السعيرة.",
    Image = "https://example.com/gulf-war-stories-image.jpg"
});

// Add the Gulf War room section to the Sections list
Sections?.Add(gulfWarRoomSection);

   }


}
 

 public class Section{
    
    private static int c=0;
    public Section(){
       c++;
       Id="s"+c;
       Items=new List<Item>();
    }
    public  string  Id{set;get;}="";
    public  string  Name{set;get;}="";
    public  string Url{set;get;}="";
    public  string  Image{set;get;}="images/mmmmp.mp4";
    public  string  Description{set;get;}="";

    public  List<Item>? Items{set;get;}


 }
 public class Item{
    public  string  Name{set;get;}="";
    public  string Description{set;get;}="";
    public  string  Image{set;get;}="";
 }


}