using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyScriptureJournal.Data; 

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 3,
                        Verse = 7,
                        Passage = "And it came to pass that I, Nephi, " +
                        "said unto my father: I awill go and do the things " +
                        "which the Lord hath commanded, for I know that the " +
                        "Lord giveth no bcommandments unto the children of men, " +
                        "save he shall cprepare a way for them that they may " +
                        "accomplish the thing which he commandeth them.",
                        Comments = "I love this verse because it teaches about courage and faith"
                    },

                    new Scripture
                    {
                        Book = "Jacob",
                        Chapter = 2,
                        Verse = 8,
                        Passage = "And it supposeth me that they have come up hither" +
                        " to hear the pleasing aword of God, yea, the word which healeth" +
                        " the wounded soul.",
                        Comments = "This scripture teaches us about the comfort of the word of God"
                    },

                    new Scripture
                    {
                        Book = "Enos",
                        Chapter = 1,
                        Verse = 6,
                        Passage = "And I, Enos, knew that God acould not lie; wherefore, my " +
                        "guilt was swept away.",
                        Comments = "This scripture shows us that Heavenly Father really does forgive"
                    },

                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = 16,
                        Verse = 16,
                        Passage = "And we did follow the adirections of the ball, which led us" +
                        " in the more fertile parts of the wilderness.",
                        Comments = "If we follow God, He will lead us where we need to be."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
