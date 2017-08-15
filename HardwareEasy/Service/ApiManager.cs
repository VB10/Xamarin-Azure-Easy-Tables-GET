using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace HardwareEasy
{
	public class ApiManager
	{
		static ApiManager defualInstance = new ApiManager();

		MobileServiceClient client;

		IMobileServiceTable<Student> loginStudent;

		public ApiManager()
		{
			client = new MobileServiceClient(ConstUrl.ConnectionUrl);
			loginStudent = client.GetTable<Student>();


		}

		public async Task<IEnumerable<Student>> getAllList()
		{
			
			return await loginStudent.ToListAsync();
		}


		public static ApiManager DefaultManager
		{
			get { return defualInstance;}
			set { defualInstance = value;}
		}
	}
}
