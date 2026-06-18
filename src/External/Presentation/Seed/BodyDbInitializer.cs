namespace Presentation.Seed;

public static class BodyDbInitializer
{
    public static async Task BodySeedAsync(FitnessContext context)
    {
        //await context.Database.EnsureCreatedAsync();
        var bodies = new List<Body>();
        if (!context.Bodies.Any())
        {
            //using var transaction = await context.Database.BeginTransactionAsync();
            bodies = new List<Body>
            {
                // 1. Neck
                new Body { Name = "Neck", GroupName = MuscleGroup.Neck, Description = ""},
                new Body { Name = "Sternocleidomastoid", GroupName = MuscleGroup.Neck, Description = "..." },
                new Body { Name = "Levator Scapulae", GroupName = MuscleGroup.Neck, Description = "..." },

                // 2. Shoulders
                new Body { Name = "Shoulders" , GroupName = MuscleGroup.Shoulders, Description=""},
                new Body { Name = "Lateral Deltoid", GroupName = MuscleGroup.Shoulders, Description ="The lateral deltoid is involved in shoulder abduction when the shoulder is internally rotated. It is involved in shoulder flexion when the shoulder is internally rotated. It is involved in shoulder transverse abduction (shoulder externally rotated) but is not utilized significantly during strict transverse extension (shoulder internally rotated)."},
                new Body { Name = "Front Shoulders" , GroupName = MuscleGroup.Shoulders, Description=""},
                new Body { Name = "Anterior Deltoid" , GroupName = MuscleGroup.Shoulders, Description=""},
                //new Body { Name = "Rear Shoulders (Posterior Deltoid)", GroupName = MuscleGroup.Neck, Description="Posterior deltoids: Rear delts that help move your arm backward. They connect to the flat surface of your shoulder blade."},
                new Body { Name = "Posterior Deltoid", GroupName = MuscleGroup.Shoulders, Description="Posterior deltoids: Rear delts that help move your arm backward. They connect to the flat surface of your shoulder blade."},

                // 3. Chest
                new Body { Name = "Chest" , GroupName = MuscleGroup.Chest, Description = ""},
                new Body { Name = "Upper Chest (Clavicular Pectoralis)", GroupName = MuscleGroup.Chest, Description = ""}, // «پکتورالیس فوقانی» به سر ترقوه‌ای عضله سینه‌ای بزرگ اشاره دارد. این بخش فوقانی و بادبزنی‌شکل عضله سینه‌ای بزرگ است که از ترقوه (استخوان ترقوه) منشأ می‌گیرد. این قسمت از عضله سینه است که بیشترین وضوح و برجستگی را در ناحیه بالای سینه دارد.
                new Body { Name = "Mid Chest (Sternal Pectoralis)", GroupName = MuscleGroup.Chest, Description = ""},
                new Body { Name = "Lower Chest", GroupName = MuscleGroup.Chest, Description = ""},
                new Body { Name = "Serratus Anterior", GroupName = MuscleGroup.Chest },

                // 4. Back
                new Body { Name = "Back", GroupName = MuscleGroup.Back, Description=""},
                new Body { Name = "Trapezius (Traps)", GroupName = MuscleGroup.Back, Description = "You have one trapezius muscle on either side of your upper back. They start at the base of your neck and extend across your shoulders and down to the middle of your back. Trapezius muscles get their name from their shape."},
                new Body { Name = "Trapezius (Upper)", GroupName = MuscleGroup.Back, Description = "" },
                new Body { Name = "Trapezius (Middle)", GroupName = MuscleGroup.Back, Description = ""},
                new Body { Name = "Trapezius (Lower) ", GroupName = MuscleGroup.Back, Description = ""},
                //new Body { Name = "Lower Traps", Description = ""},
                new Body { Name = "Latissimus Dorsi (Lats)", GroupName = MuscleGroup.Back, Description = "The latissimus dorsi muscle, commonly known colloquially as the 'lats,' is one of the largest muscles of the back, stretching across the lower posterior thorax. Its primary function is in upper extremity movement." },
                new Body { Name = "Rhomboids", GroupName = MuscleGroup.Back, Description = "The rhomboids are two bilateral, superficial muscles located in the upper back. They consist of two functionally similar muscles called rhomboid minor and rhomboid major. Together with trapezius, levator scapulae and latissimus dorsi, they comprise the superficial layer of the extrinsic back muscles." },
                new Body { Name = "Erector Spinae", GroupName = MuscleGroup.Back, Description = "rector spinae, a deep muscle of the back; it arises from a tendon attached to the crest along the centre of the sacrum (the part of the backbone at the level of the pelvis, formed of five vertebrae fused together)"},
                new Body { Name = "Teres Major", GroupName = MuscleGroup.Back },
                new Body { Name = "Teres Minor", GroupName = MuscleGroup.Back },

                // 5. Arms
                new Body { Name = "Arms", GroupName = MuscleGroup.Arms, Description = "Biceps and Triceps"},
                new Body { Name = "Biceps Brachii", GroupName = MuscleGroup.Arms, Description = "The biceps or biceps brachii (Latin: musculus biceps brachii, \"two-headed muscle of the arm\") is a large muscle that lies on the front of the upper arm between the shoulder and the elbow"}, // عضلات دو سر
                new Body { Name = "Long Head Bicep", GroupName = MuscleGroup.Arms, Description= "The long head is located on the lateral side of the biceps brachii." },
                new Body { Name = "Short Head Bicep", GroupName = MuscleGroup.Arms, Description= "short head is located on the medial side" }, // سر کوتاه عضله بازو
                new Body { Name = "Brachialis", GroupName = MuscleGroup.Arms, Description="Arms" },
                new Body { Name = "Triceps Brachii", GroupName = MuscleGroup.Arms, Description= "The triceps are located on the back of the upper arm between the shoulder and elbow joints. As noted earlier, the long head of the triceps begins in the scapula, and the medial and lateral heads begin in the humerus. The three parts of the triceps muscle meet in a tendon attached to the ulna at the elbow joint."},
                new Body { Name = "Long Head Tricep", GroupName = MuscleGroup.Arms, Description="The long head arises from the infraglenoid tubercle of scapula, which is a rough area at the inferior margin of the glenoid fossa. Its attachment extends slightly above to the adjacent glenoid labrum and blends with the glenohumeral capsule of the shoulder joint, contributing to its stability."},
                new Body { Name = "Lateral Head Triceps", GroupName = MuscleGroup.Arms, Description = "The lateral head arises from the dorsal surface of the humerus, lateral and proximal to the groove of the radial nerve, from the greater tubercle down to the region of the lateral intermuscular septum."},
                new Body { Name = "Medial Head Triceps", GroupName = MuscleGroup.Arms, Description = "The lateral head arises from the dorsal surface of the humerus, lateral and proximal to the groove of the radial nerve, from the greater tubercle down to the region of the lateral intermuscular septum"},
                
                // 6. Forearms
                new Body { Name = "Hands"},
                new Body { Name = "Forearms", GroupName = MuscleGroup.ForearmsAndHands, Description = "The forearm is the section of the upper limb from the elbow to the wrist, whose bony structure is formed by the radius (laterally) and ulna (medially)" },
                //new Body { Name = "Wrists", GroupName = MuscleGroup.Arms, Description = "" },
                new Body { Name = "Wrist Extensors", GroupName = MuscleGroup.ForearmsAndHands, Description = "The Extensor Tendon Compartments of the Wrist. They are located on the posterior aspect of the wrist. Each tunnel is lined internally by a synovial sheath and separated from one another by fibrous septa." },
                new Body { Name = "Wrist Flexors", GroupName = MuscleGroup.ForearmsAndHands, Description = "The flexor carpi radialis muscle is a long, superficial muscle of the forearm that belongs to the anterior muscle group and lies in the first layer. It is a relatively thin muscle located on the anterior part of the forearm. It arises in the humerus epicondyle, close to the wrist area." },
                new Body { Name = "Brachioradialis", GroupName = MuscleGroup.ForearmsAndHands, Description="" },
                
                // 7. Core
                new Body { Name = "Core", GroupName = MuscleGroup.Core, Description = "Your upper abdomen is the area of your belly roughly between your ribs and your belly button. Healthcare providers divide the abdomen into regions to help narrow down the many possible causes of abdominal pain. If you have upper abdominal pain, it's more likely to be related to the organs in that region."},
                new Body { Name = "Rectus Abdominis", GroupName = MuscleGroup.Core, Description = "The rectus abdominis muscles are located in the paramedian region of the anterior abdominal wall. Each muscle originates from the pubis and inserts into 5th, 6th and 7th ribs and the xyphoid process." },
                new Body { Name = "Upper Abs", GroupName = MuscleGroup.Core, Description = "Your upper abdomen is the area of your belly roughly between your ribs and your belly button. Healthcare providers divide the abdomen into regions to help narrow down the many possible causes of abdominal pain. If you have upper abdominal pain, it's more likely to be related to the organs in that region."},
                new Body { Name = "Lower Abs", GroupName = MuscleGroup.Core, Description = "" },
                new Body { Name = "Obliques (Internal & External)", GroupName = MuscleGroup.Core, Description = ""}, // پهلو
                new Body { Name = "Transverse Abdominis", GroupName = MuscleGroup.Core, Description = ""},
                
                // 8. Glutes
                new Body { Name = "Glutes", GroupName = MuscleGroup.Glutes, Description = "The gluteal muscles are a group of muscles that make up the buttock area; the muscle group consists of the gluteus maximus, gluteus medius, and gluteus minimus. The gluteus maximus is the most superficial and largest of the three muscles and makes up the bulk of the shape and form of the buttock and hip area." },
                new Body { Name = "Gluteus Maximus", GroupName = MuscleGroup.Glutes, Description = "The gluteus maximus is the most superficial and largest of the three muscles and makes up the bulk of the shape and form of the buttock and hip area." },
                new Body { Name = "Gluteus Medius", GroupName = MuscleGroup.Glutes, Description = "The gluteus medius lies between the gluteus maximus and gluteus minimus. Its posterior third is covered by the gluteus maximus, while the anterior two-thirds is superficial, covered only by a strong layer of deep fascia. [3] Gluteus medius lies on top of the gluteus minimus, covering the minimus muscle" },
                new Body { Name = "Gluteus Minimus", GroupName = MuscleGroup.Glutes, Description = "It is located just beneath the gluteus medius muscle. The gluteus minimus predominantly acts as a hip stabilizer and abductor of the hip. The muscle's blood supply and innervation are from the superior gluteal artery and superior gluteal nerve, respectively." },

                // 9. Legs (Quads + Hamstrings)
                new Body { Name = "Legs" , GroupName = MuscleGroup.Legs, Description = " "},  // // ساق‌ها جفتی از عضلات هستند که در پشت قسمت پایین پا قرار دارند
                new Body { Name = "Quadriceps", GroupName = MuscleGroup.Legs, Description = "Your quad muscles are on the front of your thigh, above your knee and below your hip. Quad tendons attach them to your pelvis, hip bones, femur (thigh bones) and kneecaps."},
                new Body { Name = "Rectus Femoris", GroupName = MuscleGroup.Legs, Description = "The rectus femoris is the anterior thigh compartment's most superficial and nearly vertically oriented muscle. This bipennate structure is a component of the quadriceps muscle complex, one of the knee's most important dynamic stabilizers."},
                new Body { Name = "Vastus Lateralis (Outer Quad)", GroupName = MuscleGroup.Legs, Description = "What Is The Outer Quad? The muscle at the front of your thigh is the quadriceps. Your outer quad, in particular, refers to the vastus lateralis muscle, which is only one of the four quad muscles in your body"},
                new Body { Name = "Vastus Medialis (Inner Quad)", GroupName = MuscleGroup.Legs, Description = "The quadriceps femoris is a hip flexor and a knee extensor. It consists of four individual muscles; three vastus muscles and the rectus femoris. They form the main bulk of the thigh, and collectively are one of the most powerful muscles in the body. It is located in the anterior compartment of the thigh."},
                new Body { Name = "Vastus Intermedius", GroupName= MuscleGroup.Legs },
                
                new Body { Name = "Hamstrings", GroupName = MuscleGroup.Legs, Description = "The hamstrings are tendons (strong bands of tissue) at the back of the thighs that attach the large thigh muscle to the bone. The term \"hamstring\" also refers to the group of 3 muscles that run along the back of your thigh, from your hip to just below your knee." },
                new Body { Name = "Biceps Femoris (Lateral)", GroupName = MuscleGroup.Legs, Description = "These muscles start at the bottom of the pelvis at a place called the ischial tuberosity. They cross the knee joint and end at the lower leg. Hamstring muscle fibers join with the tough, connective tissue of the hamstring tendons near the points where the tendons attach to bones" },
                new Body { Name = "Semimembranosus & Semitendinosus (Medial)", GroupName = MuscleGroup.Legs, Description = "These three muscles compose the hamstring muscle complex. The semimembranosus muscle lies deep to the semitendinosus muscle and is the most medial muscle of the posterior compartment of the thigh." },
                new Body { Name = "Hip Flexors (Iliopsoas)", GroupName = MuscleGroup.Legs   },
                new Body { Name = "Adductors (Inner Thigh)", Description = "The quadriceps femoris is a hip flexor and a knee extensor. It consists of four individual muscles; three vastus muscles and the rectus femoris. They form the main bulk of the thigh, and collectively are one of the most powerful muscles in the body. It is located in the anterior compartment of the thigh."},
                new Body { Name = "Feet", GroupName = MuscleGroup.Legs, Description = ""},

                // 10. Calves
                new Body { Name = "Calves", GroupName = MuscleGroup.Calves, Description = "Your calf muscle sits in the back of your lower leg. It starts below your knee and extends to your ankle. It allows you to walk, run, jump and flex your foot. It also helps you stand up straight." }, // عضله تیبیالیس جلویی در جلوی ساق پا قرار داره و کمک می‌کنه که پا رو به سمت بالا بلند کنی (مثل وقتی که می‌خوای راه بری و پات رو بلند کنی) و همچنین کمک می‌کنه که کف پات رو به داخل بچرخونی.// عضله تیبیالیس پشتی در عمق پشت پا قرار داره و کمک می‌کنه که انگشتای پات رو به پایین اشاره کنی (مثل وقتی که می‌پری یا می‌دوی)، کف پات رو به داخل بچرخونی، و قوس کف پات رو نگه داری تا محکم باشه
                new Body { Name = "Tibialis", GroupName = MuscleGroup.Calves, Description = "The Tibialis anterior (Tibialis anticus) is situated on the lateral side of the tibia; it is thick and fleshy above, tendinous below. The fibers run vertically downward, and end in a tendon, which is apparent on the anterior surface of the muscle at the lower third of the leg." }, // عضله سولئوس یک عضله عمیق در ساق پا است که در زیر عضله گاستروکنمیوس قرار دارد.
                new Body { Name = "Soleus", GroupName = MuscleGroup.Calves, Description = "Located in superficial posterior compartment of the leg Soleus is a powerful lower limb muscle, which is situated deep to the gastronemius muscle. Together with gastronemius and plantaris, it forms the calf muscle or triceps surae. It runs from back of the knee to the ankle and is multipennate."}, // عضله گاستروکنمیوس یک عضله بزرگ و قوی در پشت پای پایین توئه، که همه بهش می‌گن عضله ساق پا. این عضله درست زیر پوستته و می‌تونی حسش کنی. کمک می‌کنه انگشتای پات رو به پایین بکشی، مثل وقتی که می‌پری یا می‌دوی، و همچنین زانوت رو خم کنی!
                new Body { Name = "Gastrocnemius", GroupName = MuscleGroup.Calves, Description = "Your gastrocnemius muscle is just under your skin at the back of your lower leg. Because your gastrocnemius is close to your skin's surface, you can often see its outline. It forms the bulk of your calf muscle." },
            };
            await context.Bodies.AddRangeAsync(bodies);
            await context.SaveChangesAsync();
        }
    }
}
