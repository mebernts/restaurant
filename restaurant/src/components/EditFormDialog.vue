<template>
  <v-row>
    <v-dialog v-model="dialog2" presistent max-width="600px">
      <v-card>
        <v-card-title>Edit Dish</v-card-title>
        <v-card-text>
          <v-container>
            <v-row>
              <v-col cols="3">
                <v-text-field v-model="editId" disabled></v-text-field>
              </v-col>
              <v-col cols="3">
                <v-text-field v-model="editTable" disabled></v-text-field>
              </v-col>
              <v-col cols="3">
                <v-btn @click="getDish">Get Info</v-btn>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model="editDish.name" label="Name" required></v-text-field>
              </v-col>
              <v-col cols="12" md="6">
                <v-select v-model="editDish.category" :items="categoryList" label="Category"></v-select>
              </v-col>
              <v-col cols="12">
                <v-textarea v-model="editDish.description" label="Description" auto-grow></v-textarea>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model="editDish.price" label="Price" required></v-text-field>
              </v-col>
              <v-col cols="12" md="6">
                <v-text-field v-model="editDish.allergies" label="Allergies"></v-text-field>
              </v-col>
              <v-col cols="12">
                <v-file-input v-model="file" show-size></v-file-input>
              </v-col>
            </v-row>
          </v-container>
        </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn @click="close">Cancel</v-btn>
          <v-btn @click="putDish">Save</v-btn>
        </v-card-actions>

      </v-card>
    </v-dialog>
  </v-row>
</template>

<script>
import axios from "axios";
export default {
  name: "EditFormDialog",
  data() {
    return {
      file: null,
      categoryList: [
        "Antipasti",
        "Pizza Rosse",
        "Pizza Bianche",
        "la Pasta",
        "Brus",
        "Mineralvann",
        "Te",
        "Kaffe"
      ],
      editDish: {
        name: "",
        description: "",
        allergies: "",
        price: "",
        imageSrc: "",
        category: ""
      }
    };
  },
  props: {
    dialog2: {
      default: false
    },
    editId: {
      type: Number
    },
    editTable: {
      type: String
    }
  },
  methods: {
    close() {
      this.$emit("update:dialog2", false);
    },
    getDish() {
      if (this.editTable == "Dishes") {
        axios
          .get(`https://localhost:5001/resturant/Getdish/${this.editId}`)
          .then(result => {
            this.editDish = result.data;
          })
          .catch(error => {
            console.log(error);
          });
      } else if (this.editTable == "Drinks") {
        axios
          .get(`https://localhost:5001/resturant/Getdrink/${this.editId}`)
          .then(result => {
            this.editDish = result.data;
          })
          .catch(error => {
            console.log(error);
          });
      } else if (this.editTable == "Appertizer") {
        axios
          .get(`https://localhost:5001/resturant/Getappertizer/${this.editId}`)
          .then(result => {
            this.editDish = result.data;
          })
          .catch(error => {
            console.log(error);
          });
      }
    },
    putDish() {
      if (this.editTable == "Dishes") {
        if (this.file === null) {
          this.editDish.imageSrc = null;

          axios
            .put("https://localhost:5001/resturant/Putdish/", this.editDish)
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.editDish.imageSrc = this.file.name;

          axios
            .put("https://localhost:5001/Resturant/Putdish", this.editDish)
            .then(result => {
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/ResturantAdmin/UploadImage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      } else if (this.editTable == "Drinks") {
        if (this.file === null) {
          this.editDish.imageSrc = null;

          axios
            .put("https://localhost:5001/resturant/Putdrink/", this.editDish)
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.editDish.imageSrc = this.file.name;

          axios
            .put("https://localhost:5001/Resturant/Putdrink", this.editDish)
            .then(result => {
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/resturantadmin/uploadimage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      } else if (this.editTable == "Appertizer") {
        if (this.file === null) {
          this.editDish.imageSrc = null;

          axios
            .put(
              "https://localhost:5001/resturant/PutAppertizer/",
              this.editDish
            )
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.editDish.imageSrc = this.file.name;

          axios
            .put(
              "https://localhost:5001/resturant/PutAppertizer/",
              this.editDish
            )
            .then(result => {
              console.log(result.data);

              axios({
                method: "POST",
                url: "https://localhost:5001/ResturantAdmin/UploadImage",
                data: data,
                config: { headers: { "Content-Type": "multipart/form-data" } }
              });
            })
            .catch(error => {
              console.log(error);
            });
        }
      }
      this.$emit("update:dialog2", false);
    }
  }
};
</script>
