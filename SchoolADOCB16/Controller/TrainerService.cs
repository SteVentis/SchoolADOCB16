using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Controller
{
    public class TrainerService : IService
    {
        public void Creating()
        {
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {

                    TrainerRepository trainer = new TrainerRepository();
                    trainer.Create();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.CreateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void Deleting()
        {
            TrainerRepository trainer = new TrainerRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    trainer.Delete(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.DeleteAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void Editing()
        {
            TrainerRepository trainer = new TrainerRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    trainer.Update(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.UpdateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void Reading()
        {
            MessageToUserInput message = new MessageToUserInput();
            PrintTrainer printTrainer = new PrintTrainer();
            TrainerRepository trainer = new TrainerRepository();
            try
            {

                int id = message.WriteID();
                var trainerRead = trainer.Read(id);
                printTrainer.Print(trainerRead);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ReadingList()
        {
            TrainerRepository trainer = new TrainerRepository();
            PrintTrainer printTrainer = new PrintTrainer();
            try
            {
                var trainerList = trainer.GetListOf();
                printTrainer.PrintList(trainerList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
