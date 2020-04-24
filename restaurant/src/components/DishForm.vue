<template>
  <div>
    <v-form>
      <v-row>
        <v-col cols="12" lg="4" class="mx-auto">
          <v-select
            v-model="dishCategorySelected"
            :items="dishCategory"
            label="Kategori 1"
            required
          ></v-select>
          <v-text-field v-model="newDish.name" label="Navn" clearable></v-text-field>
          <v-textarea v-model="newDish.description" label="Description" auto-grow></v-textarea>
          <v-text-field v-model.number="newDish.price" label="Pris" prefix="kr"></v-text-field>
          <v-text-field v-model="newDish.allergies" label="Allergier"></v-text-field>
          <v-select v-model="newDish.category" label="Kategori" :items="categoryList"></v-select>
          <v-file-input v-model="file" show-size></v-file-input>
          <v-btn @click="postDish">Lagre</v-btn>
          <p>{{postStatus}}</p>
        </v-col>
      </v-row>
    </v-form>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "DishForm",
  data() {
    return {
      newDish: {
        name: "",
        description: "",
        allergies: "",
        price: "",
        imageSrc: "",
        category: ""
      },
      file: null,
      dishCategorySelected: "",
      dishCategory: ["Appertizer", "Dishes", "Drinks"],
      categoryList: [
        "Antipasti",
        "Pizza Rossa",
        "Pizza Bliance" /*rettskriv*/,
        "Drinks"
      ],
      postStatus: "Ingenting er postet enda"
    };
  },
  methods: {
    postDish() {
      if (this.dishCategorySelected == "Appertizer") {// Starts post to appertizer code
        
        if (this.file === null) {
          this.newDish.imageSrc = null;
          axios
            .post("https://localhost:5001/resturant/postAppertizer", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post("https://localhost:5001/Resturant/postAppertizer", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
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
        //End of appertizer code
      } else if (this.dishCategorySelected == "Drinks") {// Starts post to drinks code
        
        if (this.file === null) {
          this.newDish.imageSrc = null;

          axios
            .post("https://localhost:5001/resturant/postDrink", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post("https://localhost:5001/Resturant/postDrink", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
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
          // end of drinks code
        }
      } else if (this.dishCategorySelected == "Dishes") {// Starts post to dishes code
        
        if (this.file === null) {
          this.newDish.imageSrc = null;

          axios
            .post("https://localhost:5001/resturant/postdish", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
              console.log(result.data);
            })
            .catch(error => {
              console.log(error);
            });
        } else {
          let data = new FormData();
          data.append("file", this.file);
          this.newDish.imageSrc = this.file.name;

          axios
            .post("https://localhost:5001/Resturant/postdish", this.newDish)
            .then(result => {
              this.postStatus = JSON.stringify(result.data);
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
      }
      // End of Dishes code
    }
  }
};
</script>