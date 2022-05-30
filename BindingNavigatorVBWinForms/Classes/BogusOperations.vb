
Imports BindingNavigatorVBWinForms.Models

Imports Bogus

Namespace Classes
	Public Class BogusOperations
		Public Shared Function DeviceTypeList() As List(Of DeviceType)

			Dim list = New List(Of DeviceType) From {
				New DeviceType With {.Id = 1, .Description = "Home phone"},
				New DeviceType With {.Id = 2, .Description = "Work phone"},
				New DeviceType With {.Id = 3, .Description = "Home email"},
				New DeviceType With {.Id = 4, .Description = "Work email"}
			}

			Return list

		End Function
		Public Shared Function PeopleList(count As Integer) As List(Of Models.Person)

			Dim fakeAddress = New Faker(Of Address)().RuleFor(Function(p) p.Id, Function(f) f.IndexFaker).RuleFor(Function(a) a.Street, Function(f) f.Address.StreetAddress()).RuleFor(Function(a) a.PostalCode, Function(f) f.Address.ZipCode())
			Dim fakeContactDevices = (New Faker(Of ContactDevice)()).RuleFor(Function(p) p.Id, Function(f) f.IndexFaker).RuleFor(Function(c) c.DeviceTypeId, Function(f) f.Random.Int(1, 4)).RuleFor(Function(c) c.DeviceType, Function(f) f.PickRandom(DeviceTypeList)).RuleFor(Function(c) c.Value, Function(f) f.Phone.PhoneNumber())
			Dim fakePerson As Faker(Of Models.Person) = (New Faker(Of Models.Person)()).RuleFor(Function(p) p.Id, Function(f) f.IndexFaker).RuleFor(Function(p) p.FirstName, Function(f) f.Name.FirstName()).RuleFor(Function(p) p.LastName, Function(f) f.Name.LastName()).RuleFor(Function(p) p.Addresses, Function(f) fakeAddress.Generate(4)).RuleFor(Function(p) p.ContactDevices, Function(f) fakeContactDevices.Generate(1))
			Dim list As List(Of Models.Person) = fakePerson.Generate(count)

			Return list

		End Function
	End Class
End Namespace

